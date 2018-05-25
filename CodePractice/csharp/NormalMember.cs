using System;
namespace CodePractice
{
    class NormalMember : Member // Creating child class "Normal Member" from parent class "Member"
    {
        public NormalMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince) // remarks is the only parameter passed into the child constructor. The other three are passed into the parent constructor
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Message = {0}", remarks);
        }

        public void CalculateAnnualFee() // child class inherits protected field annualFee from parent/base class
        {
            annualFee = 100 + 12 * 30;
        }
    }
}
