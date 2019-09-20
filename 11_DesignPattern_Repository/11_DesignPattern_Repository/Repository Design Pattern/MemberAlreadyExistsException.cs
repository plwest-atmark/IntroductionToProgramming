using System;
using System.Runtime.Serialization;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{
    [Serializable]
    internal class MemberAlreadyExistsException : Exception
    {
        private Member member;
        private string v;

        public MemberAlreadyExistsException()
        {
        }

        public MemberAlreadyExistsException(string message) : base(message)
        {
        }

        public MemberAlreadyExistsException(Member member, string message) : base(message)
        {
            this.member = member;
            this.v = v;
        }

        public MemberAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MemberAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}