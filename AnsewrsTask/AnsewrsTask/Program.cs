using System;
using System.Runtime.InteropServices;

namespace AnsewrsTask
{
    internal class Program
    {
        static void Main(string[] args)

        {
             
            mcq q1 = new mcq(1,"your name ?",5);
           
            q1.arr = new string[]
           {
               "mahmoud",
               "ahmed",
               "mohamed",
           };
           
            mcq q2 = new mcq(1, "your name ?", 5);
            q2.arr = new string[]
           {
               "mahmoud",
               "ahmed",
               "mohamed",
           };
            Console.WriteLine("q1 is equal q2 ===>" + q1.Equals(q2));
            Console.WriteLine("===============================>");
            Console.WriteLine(q1.ToString());
            Console.WriteLine("===============================>");
            Console.WriteLine(q2.ToString());
            Console.WriteLine("===============================>");
            TrueOrFalse q3 = new TrueOrFalse(2,"your age between 18:23 ?",4);
            TrueOrFalse q4 = new TrueOrFalse(4, "your age between 18:25 ?",12);
            
            Console.WriteLine("q1 is equal q2 ===>" + q3.Equals(q4));
            Console.WriteLine("===============================>");
            Console.WriteLine(q3.ToString());
            Console.WriteLine("===============================>");
            Console.WriteLine(q4.ToString());



        }
    }
        class ques {
        public int num;
        public int mark;
        public string body;
        public int Num{ 
            get { return num; }
            set { num = value; }
        }
        public int Mark{ 
            get { return mark; }    
            set { mark = value; }   
        }
        public string Body
        {
            get { return Body; }
            set { Body = value; }
        } 
        public ques():this(0) {
            
        }
        public ques(int num):this(num,"")
        {
           
        }
        public ques(int num, string body):this(num,body,0)
        {
           
            
            
        }

        public ques(int num, string _body,int mark) 
        {
            this.num = num;
            
            this.body = _body;
            this.mark = mark;
        }
        
        
        
    }
     class mcq :ques {
        public String [] arr;
        public String [] Arr {
            get { return arr; }
            set { arr = value; }  
        }

        public mcq(int num, String body, int mark) : base(num, body, mark) { }
        public override string ToString()
        {
            return($"{this.num}==>{this.body} \nAnsewrs:-\nA-{this.arr[0]}\nB-{this.arr[1]}\nc-{this.arr[2]} \nmark:- {this.mark}");

        }
        public override bool Equals(object? obj)
        {
            mcq mcq = (mcq) obj;
            return this.num==mcq.num && this.body==mcq.body && this.mark==mcq.mark ;
        }

    }
    class TrueOrFalse:ques{

        public TrueOrFalse(int num, String body, int mark) : base(num, body, mark) { }
        public override string ToString() 
        {
            return ($"{this.num}==>{this.body}\nAnsewrs:-\n(True / False)\nmark:- {this.mark}");

        }

        public override bool Equals(object? obj)
        {
            TrueOrFalse tor = (TrueOrFalse)obj;
            return this.num == tor.num && this.body == tor.body && this.mark == tor.mark;
        }


    }

}