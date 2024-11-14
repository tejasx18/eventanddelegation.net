using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eventanddelegation.Program;

namespace eventanddelegation
{
    public class Student
    {
        // event
        public event DisplayMessage Pass;// it is an event name
        public event DisplayMessage Fail;

        public void AcceptMarks(int marks)
        {
            if (marks >= 40)
            {
                Pass();  // raise an event /  call to event
            }
            else
            {
                Fail();
            }
        }
    }
}
