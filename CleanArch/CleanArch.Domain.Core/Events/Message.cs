using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        /// <summary>
        /// contructor
        /// </summary>
        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
