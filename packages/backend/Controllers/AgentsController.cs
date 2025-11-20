using Microsoft.AspNetCore.Mvc;
using atlas.Models;
using System.Diagnostics.Eventing.Reader;

namespace atlas.Controllers;

[ApiController]
[Route("[controller]")]
public class AgentsController : ControllerBase
{
    static private List<Agent> agents = new List<Agent>
    {
        new Agent { Id = 1, Name = "John Smith", Email = "john.smith@example.com", Phone = "+1-555-0101" },
        new Agent { Id = 2, Name = "Sarah Johnson", Email = "sarah.johnson@example.com", Phone = "+1-555-0102" },
        new Agent { Id = 3, Name = "Michael Chen", Email = "michael.chen@example.com", Phone = "+1-555-0103" },
        new Agent { Id = 4, Name = "Emily Davis", Email = "emily.davis@example.com", Phone = "+1-555-0104" },
        new Agent { Id = 5, Name = "Robert Williams", Email = "robert.williams@example.com", Phone = "+1-555-0105" }

    };

    //request all agents
    [HttpGet]
    public ActionResult<List<Agent>> GetAgents()
    {
        return Ok(agents);
    }

    [HttpGet("{id}")]
    public ActionResult<Agent> GetAgentById(int id)
    {
        var agent = agents.FirstOrDefault(x => x.Id == id);
        if (agent == null)
            return NotFound();
        return Ok(agent);
    }

    [HttpPost]
    public ActionResult<Agent> PostNewAgent(Agent newAgent)
    {
        if (newAgent == null)
            return BadRequest();

        agents.Add(newAgent);
        return CreatedAtAction(nameof(GetAgentById), new { id = newAgent.Id }, newAgent);

    }

}
