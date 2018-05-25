using System;
namespace CodePractice
{
    class VIPMember : Member // Creating child class "VIPMember" derived from parent class "Member"
    {
        public VIPMember(string name, int memberID, int memberSince) : base(name , memberID, memberSince) // Child constructor with 3 parameters
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public void CalculateAnnualFee() // method
        {
            annualFee = 1200;
        }
    }

}
