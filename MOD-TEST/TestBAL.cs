using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MOD_BAL;
using MOD_DAL;
namespace MOD_TEST
{
    [TestFixture]
    public class TestBAL
    {
        [Test]
        public void GetById()
        {
            UL user = new UL();
            UserDtl user1 = user.GetDetails(1);
            Assert.IsNotNull(user1);
        }

        [Test]
        public void Register()
        {
            UL user = new UL();
            UserDtl user1 = new UserDtl()
            {
                firstName = "Dhananjay",
                lastName = "Yadav",
                userName = "DhananjayYadav",
                password = "98989898",
                email = "dy34@gmail.com",
                contactNumber = 9876350744,
                active = true,
                role = 1,
            };
            user.SignUp(user1);
            UserDtl user2 = user.GetDetails(4);
            Assert.IsNotNull(user2);
        }

        [Test]
        public void GetAllUser()
        {
            UL user = new UL();
            IList<UserDtl> p = user.GetAll();
            Assert.IsNotNull(p);
        }

        [Test]
        public void Update()
        {
            UL user = new UL();
            PaymentDtl user1 = new PaymentDtl()
            {
                remarks = "",
                amount = 500,
                mentorId = 3,
                mentorName = "arvind",
                trainingId = 1,
                skillName = "Java",
                totalAmountToMentor = 400,
                commision = 100
                //
            };
            user.UpdatePayment(4, user1);
            PaymentDtl user2 = user.GetPaymentDetails(4);
            Assert.IsTrue(user1.amount == user2.amount && user1.mentorName == user2.mentorName);
        }
        [Test]
        public void Delete()
        {
            UL user = new UL();
            user.DeleteEmployee(3);
            SkillDtl user2 = user.skillById1(3);
            Assert.IsNull(user2);
        }





    }
}
