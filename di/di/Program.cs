using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace di
{
     class Program
    {
        static void Main(string[] args)
        {
            BussinessLogicService objBussinessLogicService = new BussinessLogicService(new StudentService()); //create injector class  in that we inject service class (new StudentservicE)
            Console.ReadKey();
        
        }
    }

    public class BussinessLogicService //create client class
    {
        private IService iService; //constructor di
        
        public BussinessLogicService(IService _iService) //create constructor (_iservice humne inject kri hai particular service)
        { 
             this.iService = _iService;
            this.iService.GetFirstName();
            this.iService.GetLastName();
        }

    }

    public interface IService
    {
        void GetFirstName();//create method
        void GetLastName();
    }

    public class StudentService : IService //create a service class ( studentservice class nherits service)
    {
        public void GetFirstName() 
        {
            Console.WriteLine("Studet First Name");
        }
        public void GetLastName() 
        {
            Console.WriteLine("Studet Last Name");
        }
    }

    public class TeacherService : IService //create more service class
    {
        public void GetFirstName()
        {
            Console.WriteLine("Teacher First Name");
        }
        public void GetLastName()
        {
            Console.WriteLine("Teacher Last Name");
        }
    }

   
    }
}

