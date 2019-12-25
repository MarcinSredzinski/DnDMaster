using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Library.Characteristics;
using CoreLibrary.Enums;
using CoreLibrary.Repositories;
using CoreLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace DnDUI.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterService _characterService;
        private readonly IRepository _characterRepository;

        public CharacterController(ICharacterService characterService, IRepository characterRepository)
        {
            _characterService = characterService;
            _characterRepository = characterRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GenerateCharacter()
        {
            //Display form used to assign character's properties like description etc

            return View();
        }
        [HttpPost]
        public IActionResult GenerateCharacter(CharactersTypes charactersType)
        {
            //1) I have an user
            //2) I have selected by user specyfic character(polymorphism!)
            //3) Navigating through the views I collect required data to fill all the info of the character.
            //3) _characterService gets all required parameters
            //4) _characterService generates specyfic character with the parameters
            //5) _characterService calls _characterRepository to save the character
            return View();
        }
    }
}