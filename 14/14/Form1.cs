using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BankModel Bank;
        int N;
        double T;
        int NumberOfOperators;
        double flowLambda, serversLambda;
        public Dictionary<int, double> EmpiricStat;
        public Dictionary<int, double> TheoreticalStat;

        private void Start_Click(object sender, EventArgs e)
        {
            flowLambda = (double)fl.Value;
            serversLambda = (double)sl.Value;
            NumberOfOperators = (int)OpBox.Value;
            Bank = new BankModel(flowLambda, serversLambda, NumberOfOperators);

            T = (double)TBox.Value;
            N = (int)Nbox.Value;

            for (int i = 0; i < N; i++)
            {
                Bank.PredetermineFlow(T);
                Bank.Work(T);
                Bank.AddStat();
            }
            EmpiricStat = Bank.GetStat(N);
            TheoreticalStat = GetTheoryStat(EmpiricStat);

            AllCustomersBox.Text = "Total customers: " + (Bank.CustomerAll / N).ToString();
            ServedBox.Text = "Total served: " + (Bank.CustomerServed/N).ToString();
            AvgInBankBox.Text = "Avg. time in bank: " + String.Format("{0:0.00}", Bank.GetAvgTimeInBank());
            AvgInQBox.Text = "Avg. time in queue: " + String.Format("{0:0.00}", Bank.GetAvgTimeInQ());


            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            foreach (int i in EmpiricStat.Keys)
            {
                chart1.Series[0].Points.AddXY(i, EmpiricStat[i]);
            }
            foreach (int i in TheoreticalStat.Keys)
            {
                chart2.Series[0].Points.AddXY(i, TheoreticalStat[i]);
            }
        }

        public Dictionary<int, double> GetTheoryStat(Dictionary<int, double> stat)
        {
            double rho = flowLambda / serversLambda;
            double dist = StationaryDistributionOfClients();
            foreach (int i in stat.Keys.ToList())
            {
                if (i < NumberOfOperators)
                {
                    stat[i] = (Math.Pow(rho, i) / Factorial(i)) * dist;
                }
                else
                {
                    stat[i] = (Math.Pow(rho, i) / (Factorial(i) * Math.Pow(NumberOfOperators, i - NumberOfOperators))) * dist;
                }
            }
            return stat;

        }
        public double StationaryDistributionOfClients()
        {
            double temp1 = 0;
            double rho = flowLambda / serversLambda;
            for (int i = 0; i < NumberOfOperators; i++)
            {
                temp1 += Math.Pow(rho, i) / Factorial(i);
            }
            double temp2 = Math.Pow(rho, NumberOfOperators + 1) / Factorial(NumberOfOperators) * (NumberOfOperators - rho);
            double val = Math.Pow(temp1 + temp2, -1);
            return val;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public int Factorial(int k)
        {
            int ans = 1;
            for (int i = 1; i <= k; i++)
            {
                ans *= i;
            }
            return ans;
        }
    }

    class BankModel
    { 
        double Time;
        SortedDictionary<double, string> Events; 
        public Queue queue;
        public ServiceArea servers;
        public InputFlow flow;

        public int CustomerAll;
        public int CustomerServed;
        public Dictionary<int, double> EmpiricStat;
        public List<double> EmpiricAvgTimeInBank;
        public List<double> EmpiricAvgTimeInQ;

        public BankModel(double fl, double sl, int NumOper)
        {
            Time = 0;
            EmpiricStat = new Dictionary<int, double>();
            EmpiricAvgTimeInBank = new List<double>();
            EmpiricAvgTimeInQ = new List<double>();
            CustomerAll = 0;
            CustomerServed = 0;

            flow = new InputFlow(fl);
            queue = new Queue();
            servers = new ServiceArea();
            for(int i = 0; i < NumOper; i++){
                servers.Add(new Operator(sl));
            }         
        }

        public void Work(double T)
        {
            Time = 0;
            KeyValuePair<double,string> evnt;
            while(Time < T)
            {
                Events.OrderBy(x => x.Key);
                evnt = Events.First();
                if(evnt.Value == "flow")
                {
                    CustomerAll++;
                    Customer c =  flow.ProcessEvent(Time);
                    Operator o =  servers.GetFreeOperator();
                    if(o != null)
                    {
                        int busy = servers.HowManyBusy();
                        KeyValuePair<double, string> temp = o.GetNextEvent(Time, busy, c);
                        Events.Add(temp.Key,temp.Value);
                    } else
                    {
                        queue.Add(c, Time);                        
                    }
                    Events.Remove(evnt.Key);
                    Time = evnt.Key;
                } else if(evnt.Value == "oper")
                {                    
                    Operator o = servers.GetOperator(evnt.Key);
                    o.ProcessEvent(Time, EmpiricAvgTimeInBank, EmpiricAvgTimeInQ);
                    Time = evnt.Key;
                    Events.Remove(evnt.Key);
                    CustomerServed++;
                    if (queue.Customers.Any())
                    {
                        Customer c = queue.GetNextCustomer(Time);
                        int busy = servers.HowManyBusy();
                        KeyValuePair<double, string> temp = o.GetNextEvent(Time, busy, c);
                        Events.Add(temp.Key, temp.Value);
                    }
                }               
            }

        }

        public void PredetermineFlow(double T)
        {
            Time = 0;
            Events = new SortedDictionary<double, string>();
            servers.AllOpsFree();
            queue.ClearQueue();
            queue.SetSize(0);

            KeyValuePair<double, string> evnt;
            while (Time < T)
            {
                evnt = flow.GetNextEvent(Time);
                if(evnt.Key > 0)
                {
                    Events.Add(evnt.Key, evnt.Value);
                    Time = evnt.Key;
                }
            }
            Time = 0;
        }

        public void AddStat()
        {
            int state = queue.GetSize() + servers.HowManyBusy();
            if (!EmpiricStat.ContainsKey(state))
            {
                EmpiricStat.Add(state, 1); 
            }
            else
            {
                EmpiricStat[state]++; 
            }
        }
        public Dictionary<int, double> GetStat(int N)
        {
            Dictionary<int, double> statistic = EmpiricStat;
            foreach (int i in EmpiricStat.Keys.ToList())
            {
                statistic[i] /= N;
            }
            return statistic;
        }

        public double GetAvgTimeInBank()
        {
            double avg = 0;
            foreach(double val in EmpiricAvgTimeInBank)
            {
                avg += val;
            }
            avg /= EmpiricAvgTimeInBank.Count();
            return avg;
        }

        public double GetAvgTimeInQ()
        {
            double avg = 0;
            foreach (double val in EmpiricAvgTimeInQ)
            {
                avg += val;
            }
            avg /= EmpiricAvgTimeInQ.Count();
            return avg;
        }

        public class Queue
        {
            public List<Customer> Customers = new List<Customer>();
            int size;

            public Queue()
            {
                size = 0;
            }

            public void Add(Customer c, double T)
            {
                size++;
                c.TimeInQ = T;
                Customers.Add(c);
            }

            public Customer GetNextCustomer(double T)
            {
                size--;
                Customer cus = Customers.First();
                Customers.Remove(cus);
                if(cus.TimeInQ != 0)
                {
                    cus.TimeInQ = T - cus.TimeInQ;
                }
                
                return cus;
            }

            public bool IsEmpty()
            {
                if (Customers.Count == 0)
                    return true;
                return false;
            }

            public void ClearQueue()
            {
                Customers = new List<Customer>();
            }
            public void SetSize(int x)
            {
                size = x;
            }
            public int GetSize()
            {
                return size;
            }
        }

        public class Customer
        {
            public double TimeInBank, StartingTime, TimeInQ;
            public Customer(double T)
            {
                StartingTime = T;
                TimeInBank = 0;
                TimeInQ = 0;
            }
        }

        public class Operator
        {
            Random rnd = new Random();
            string[] States = { "Free", "Busy" };
            string State;
            public double EndTime;
            double lambda;
            public Customer cus;

            public Operator(double sl)
            {
                State = States[0];
                lambda = sl;
            }

            public bool IsFree()
            {
                if (State == States[1])
                {
                    return false;
                }
                return true;
            }

            public KeyValuePair<double, string> GetNextEvent(double T, int busy, Customer c)
            { 
                EndTime = T + (-Math.Log(rnd.NextDouble()) / lambda);
                cus = c;
                State = States[1];
                return new KeyValuePair<double, string>(EndTime, "oper");
            }

            public void ProcessEvent(double T, List<double> EATIB, List<double> EATIQ)
            {
                cus.TimeInBank = (T - cus.StartingTime) + cus.TimeInQ;
                EATIB.Add(cus.TimeInBank);
                EATIQ.Add(cus.TimeInQ);
                State = States[0];
            }

            public void Free()
            {
                State = States[0];
            }
        }     

        public class InputFlow
        {
            public double NextArrival;
            Random rnd = new Random();
            double lambda;

            public InputFlow(double l)
            {
                NextArrival = 0;
                lambda = l;
            }


            public KeyValuePair<double, string> GetNextEvent(double T)
            {
                NextArrival = T + (-Math.Log(rnd.NextDouble()) / lambda);
                return new KeyValuePair<double, string>(NextArrival, "flow");
            }

            public Customer ProcessEvent(double T)
            {
                return new Customer(T);
            }

        }

        public class ServiceArea
        {
            List<Operator> Operators = new List<Operator>();

            public Operator GetFreeOperator()
            {
                foreach (Operator oper in Operators)
                {
                    if (oper.IsFree())
                        return oper;
                }
                return null;
            }
            public void Add(Operator o)
            {
                Operators.Add(o);
            }

            public Operator GetOperator(double t)
            {
                return Operators.FirstOrDefault(x => x.EndTime == t);
            }

            public void AllOpsFree()
            {
                foreach(Operator oper in Operators)
                {
                    oper.Free();
                }
            }

            public int HowManyBusy()
            {
                int count = Operators.Count();
                foreach(Operator oper in Operators)
                {
                    if (oper.IsFree())
                        count--;
                }
                return count;
            }
        }
    }
}
