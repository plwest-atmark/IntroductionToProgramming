using System;
using System.Runtime.Serialization;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{
    [Serializable]
    internal class MemberNotFoundException : Exception
    {
        private Member member;
        public override string Message => base.Message;

        public MemberNotFoundException()
        {
        }

        public MemberNotFoundException(Member member, string message) : base(message)
        {
            this.member = member;
        }

        public MemberNotFoundException(string message, string lastName) : base(message)
        {
        }

        public MemberNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MemberNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}