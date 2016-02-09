using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Consultancy.Application.Context;
using Consultancy.Application.Models;

namespace Consultancy.Application.Controllers.Api
{
    public class ConsultanciesController : ApiController
    {
        private AbcDbContext db = new AbcDbContext();

        // GET: api/Consultancies
        public IQueryable<Consultancies> GetConsultancies()
        {
            return db.Consultancies;
        }

        // GET: api/Consultancies/5
        [ResponseType(typeof(Consultancies))]
        public IHttpActionResult GetConsultancies(int id)
        {
            Consultancies consultancies = db.Consultancies.Find(id);
            if (consultancies == null)
            {
                return NotFound();
            }

            return Ok(consultancies);
        }

        // PUT: api/Consultancies/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutConsultancies(int id, Consultancies consultancies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != consultancies.Id)
            {
                return BadRequest();
            }

            db.Entry(consultancies).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultanciesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Consultancies
        [ResponseType(typeof(Consultancies))]
        public IHttpActionResult PostConsultancies(Consultancies consultancies)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Consultancies.Add(consultancies);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = consultancies.Id }, consultancies);
        }

        // DELETE: api/Consultancies/5
        [ResponseType(typeof(Consultancies))]
        public IHttpActionResult DeleteConsultancies(int id)
        {
            Consultancies consultancies = db.Consultancies.Find(id);
            if (consultancies == null)
            {
                return NotFound();
            }

            db.Consultancies.Remove(consultancies);
            db.SaveChanges();

            return Ok(consultancies);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ConsultanciesExists(int id)
        {
            return db.Consultancies.Count(e => e.Id == id) > 0;
        }
    }
}