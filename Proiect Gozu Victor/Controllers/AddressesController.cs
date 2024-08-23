﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect_Gozu_Victor.Data;
using Proiect_Gozu_Victor.DTO;
using Proiect_Gozu_Victor.DTO.Extensions;
using Proiect_Gozu_Victor.Services;

namespace Proiect_Gozu_Victor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly StudentsService studentsService;
        private readonly AddressesService addressesService;
        private readonly MarksService marksService;
        private readonly StudentsRegistryDbContext ctx;

        public AddressesController(StudentsService studentsService, AddressesService addressesService, MarksService marksService, StudentsRegistryDbContext ctx)
        {
            this.studentsService = studentsService;
            this.addressesService = addressesService;
            this.marksService = marksService;
            this.ctx = ctx;
        }

        [HttpPost]
        public AddressToGetDto AddAddres([FromBody] AddressToCreateDto addressToCreate) =>
               addressesService.AddAddress(
                   addressToCreate.City, addressToCreate.Street, addressToCreate.No
                   ).ToAddressToGet();
    }
}
