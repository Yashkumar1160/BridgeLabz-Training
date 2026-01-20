using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.password_cracker
{
    internal interface IPassword
    {
        //method to set a password
        void SetPassword();

        //method to generate different passwords
        void GeneratePasswords(int index, char[]attempt);

        //method to start password cracking
        void StartPasswordCracking();

    }
}
