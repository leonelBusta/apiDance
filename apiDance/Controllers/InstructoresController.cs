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
using apiDance.Models;

namespace apiDance.Controllers
{
    public class InstructoresController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Instructores
        public IQueryable<Instructores> GetInstructores()
        {
            return db.Instructores;
        }

        // GET: api/Instructores/5
        [ResponseType(typeof(Instructores))]
        public IHttpActionResult GetInstructores(int id)
        {
            Instructores instructores = db.Instructores.Find(id);
            if (instructores == null)
            {
                return NotFound();
            }

            return Ok(instructores);
        }

        // PUT: api/Instructores/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInstructores(int id, Instructores instructores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != instructores.idInstructores)
            {
                return BadRequest();
            }

            db.Entry(instructores).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructoresExists(id))
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

        // POST: api/Instructores
        [ResponseType(typeof(Instructores))]
        public IHttpActionResult PostInstructores(Instructores instructores)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Instructores.Add(instructores);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = instructores.idInstructores }, instructores);
        }

        // DELETE: api/Instructores/5
        [ResponseType(typeof(Instructores))]
        public IHttpActionResult DeleteInstructores(int id)
        {
            Instructores instructores = db.Instructores.Find(id);
            if (instructores == null)
            {
                return NotFound();
            }

            db.Instructores.Remove(instructores);
            db.SaveChanges();

            return Ok(instructores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool InstructoresExists(int id)
        {
            return db.Instructores.Count(e => e.idInstructores == id) > 0;
        }
    }
}