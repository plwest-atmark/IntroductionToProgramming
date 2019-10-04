using System;
using System.Runtime.Serialization;

namespace _11_DesignPattern_Repository.Repository_Design_Pattern
{
    [Serializable]
    internal class MemberAlreadyExistsException : Exception
    {
        private Member member;

        /// <summary>
        ///  Setting this constructor to private means that we MUST send a member and a message
        ///     when we create this custom exception.  This can be a good practice when there is
        ///     critical information that is required to be returned with an exception.
        /// </summary>
        private MemberAlreadyExistsException()
        {
        }

        public MemberAlreadyExistsException(Member member, string message) : base(message)
        {
            this.member = member;
        }

        #region Do not worry about these constructors for now.
        public MemberAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MemberAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        #endregion
    }
}