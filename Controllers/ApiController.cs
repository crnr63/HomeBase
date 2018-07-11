using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HomeBase.Models;

namespace HomeBase.Controllers
{
    [Route("api/[controller]")]
    public class REDataController : ControllerBase
    {
        private readonly FantasyZoneContext _context;
        private readonly QOTDContext _qotdContext;

        private readonly RealEstateContext _realEstateContext;

   public REDataController(
      FantasyZoneContext FantasyZoneContext,
           QOTDContext QOTDContext,
          RealEstateContext RealEstateContext 
           ){
            _context = FantasyZoneContext;
            _qotdContext=  QOTDContext;
        _realEstateContext=RealEstateContext;

            }
        [HttpGet]
        public List<USAHouses> GetAll()
        {
            return  _qotdContext.USAHouses.ToList();
        }

        [HttpGet("{id}", Name = "GetUSAHome")]
        public IActionResult GetById(int id)
        {
            var item = _qotdContext.USAHouses.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public IActionResult Create([FromBody] USAHomeSales homeinfo)
        {
            if ( homeinfo == null)
            {
                return BadRequest();
            }

            _realEstateContext.USAHomeSales.Add(homeinfo);
            _realEstateContext.SaveChanges();

            return CreatedAtRoute("GetHome", new { id = homeinfo.ID }, homeinfo);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] USAHomeSales homeinfo)
        {
            if (homeinfo == null || homeinfo.ID != id)
            {
                return BadRequest();
            }

            var homesalesinfo = _realEstateContext.USAHomeSales.Find(id);
            if (homeinfo == null)
            {
                return NotFound();
            }

           homesalesinfo.finalsalesprice = homeinfo.finalsalesprice;
            homesalesinfo.insertionDate = homeinfo.insertionDate;
homesalesinfo.listingprice= homeinfo.listingprice;
homesalesinfo.snapshottype= homeinfo.snapshottype;
homesalesinfo.snapshotdate=homeinfo.snapshotdate;
homesalesinfo.notes=homeinfo.notes;


          _realEstateContext.USAHomeSales.Update(homesalesinfo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _realEstateContext.USAHomeSales.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _realEstateContext.USAHomeSales.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }

    }

// 555555555555555555555555555555555555555555555555
/* 
public class FantasyDataController : ControllerBase
    {
        private readonly FantasyZoneContext _context;
        private readonly QOTDContext _qotdContext;

   public FantasyDataController(
      FantasyZoneContext FantasyZoneContext,
           QOTDContext QOTDContext
           ){
            _context = FantasyZoneContext;
            _qotdContext=  QOTDContext;
          

            }
        [HttpGet]
        public List<USAHouses> GetAll()
        {
            return  _qotdContext.USAHouses.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            var item = _qotdContext.USAHouses.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.TodoItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] TodoItem item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _context.TodoItems.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.TodoItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }

    }

*/


}