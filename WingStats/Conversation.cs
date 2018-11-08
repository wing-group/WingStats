﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingStats
{
    /// <summary>
    /// Keeps info, stats, and users for a conversation
    /// </summary>
    class Conversation
    {
        private string name;
        private int totalMessagesSent;
        private List<User> members;

        /// <summary>
        /// Create a new conversation instance
        /// </summary>
        /// <param name="name">The name of the conversation</param>
        public Conversation(string name)
        {
            this.name = name;

            members = new List<User>();
        }

        /// <summary>
        /// Add a new member to the conversation
        /// </summary>
        /// <param name="name"></param>
        public void addUser(string name)
        {
            this.members.Add(new User(name));
        }

        /// <summary>
        /// Add a message to the conversation
        /// </summary>
        public void addMessage(string name, string message)
        {
            foreach(User user in members)
            {
                if(user.getName() == name)
                {
                    user.addMessage(message);
                    totalMessagesSent++;
                }
            }
        }
    }
}