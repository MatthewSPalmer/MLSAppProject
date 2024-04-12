using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSApp
{
    interface IAgentCRUD  //  Interface for performing CRUD operations with the Agent class
    {
        int GetMaxAgentId();
        void AddAgent(Agent agent);
        void RemoveAgent(Agent agent);
        void UpdateAgent(int agentId, Agent agent);
        ICollection<Agent> GetAgents();
        Agent GetAgentById(int agentId);
        Agent GetAgentByUsername(string username);
        ICollection<House> GetHouses();
        string GetAgentName(int agentId);
    }
    class AgentCRUD : IAgentCRUD
    {
        MLSAppDBEntities entities;  //  Used to access and modify the DB
        public AgentCRUD()
        {
            entities = new MLSAppDBEntities();  
        }
        public void AddAgent(Agent agent)  //  Add the passed agent info to DB
        {
            entities.Agents.Add(agent);
            entities.SaveChanges();
        }

        public Agent GetAgentById(int agentId)  //  Find and return agent from DB by AgentId
        {
            return entities.Agents.Find(agentId);
        }

        public Agent GetAgentByUsername(string username)  //  Didn't use, leaving for future functionality
        {
            return entities.Agents.Find(username);
        }

        public string GetAgentName(int agentId)  //  Lookup and return Agent name in DB
        {
            Agent agent = new Agent();
            agent = entities.Agents.Find(agentId);
            return agent.Name;
        }

        public ICollection<Agent> GetAgents()  //  Didn't use, leaving for future functionality
        {
            return entities.Agents.ToList();
        }

        public ICollection<House> GetHouses()  //  Returns houses in DB as a list
        {
            return entities.Houses.ToList();
        }

        public int GetMaxAgentId()  //  Returns max AgentId in DB (used to set new AgentId)
        {
            return entities.Agents.Max(a => a.AgentID);
        }

        public void RemoveAgent(Agent agent)  //  Removes the passed Agent from DB
        {
            entities.Agents.Remove(agent);
            entities.SaveChanges();
        }

        public void UpdateAgent(int agentId, Agent agent)  //  Updates Agent info in DB
        {
            var agentupdate = entities.Agents.Find(agentId);
            agentupdate.AgentID = agent.AgentID;
            agentupdate.Username = agent.Username;
            agentupdate.Password = agent.Password;
            agentupdate.Name = agent.Name;
            agentupdate.Phone = agent.Phone;
            agentupdate.Email = agent.Email;
            entities.SaveChanges();
        }
    }
}
