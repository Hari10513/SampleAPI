using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public List<Model> Models = new List<Model>()
        {
            new Model { Id = 1, Title = "The Girl on the train", Author = "Hawkins, Paula", PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 2, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 3, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 4, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 5, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 6, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 7, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 8, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 9, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"},
            new Model { Id = 10, Title = "The Girl on the train", Author = "Hawkins, Paula",PublicationYear = 2017, CallNumber = "7904932295"}
        };

        [HttpGet]

        public ActionResult<IEnumerable<Model>> GetAllModels()
        {
            return Models;
        }

        [HttpGet("{id}")]

        public ActionResult<Model> GetModel(int id)
        {
            var Model = Models.FirstOrDefault(x => x.Id == id);
            if (Model == null)
            {
                return NotFound();
            }
            return Model;
        }

    }
}
