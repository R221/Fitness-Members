using System;

namespace CodePractice
{
    class Member // Member Class
    {
        static void Main() // Main Method is the entry point for all apps and is the first method run
        {
            NormalMember mem1 = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember mem2 = new VIPMember("Andy", 2, 2011);
        }

        protected int annualFee; // 4 Fields
        private string name;
        private int memberID;
        private int memberSince;

        public override string ToString() // String override
        {
            return "\nName:" + name + "\nMember ID:" + memberID + "\nMember Since:" + memberSince + "\nTotal Annual Fee:" + annualFee;
        }

        public Member() // Base Constructor 1
        {
            Console.WriteLine("Parent Constructor with no parameters");
        }

        public Member(string pName, int pMemberID, int pMemberSince) // Base Constructor 2
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }
    }
}

