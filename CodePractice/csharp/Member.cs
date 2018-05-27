using System;

namespace CodePractice
{
    class Member // Member Class
    {
        static void Main() // Main Method is the entry point for all apps and is the first method run
        {
            Member[] clubMembers = new Member[5];

            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member m in clubMembers)
            {
                m.CalculateAnnualFee();
                Console.WriteLine(m.ToString());
            }

            if (clubMembers[0].GetType() == typeof(VIPMember))
                Console.WriteLine("Yes");
            else
            {
                Console.WriteLine("No");
            }
        }

        protected int annualFee; // 4 Fields
        private string name;
        private int memberID;
        private int memberSince;

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }

        public override string ToString() // String override
        {
            return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince + "\nTotal Annual Fee: " + annualFee;
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

