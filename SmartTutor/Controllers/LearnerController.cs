using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartTutor.Controllers.DTOs.Learner;
using SmartTutor.LearnerModel;
using SmartTutor.LearnerModel.Exceptions;
using SmartTutor.LearnerModel.Learners;

namespace SmartTutor.Controllers
{
    [Route("api/learners/")]
    [ApiController]
    public class LearnerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILearnerService _learnerService;

        public LearnerController(IMapper mapper, ILearnerService learnerService)
        {
            _mapper = mapper;
            _learnerService = learnerService;
        }

        [HttpPost("register")]
        public ActionResult<LearnerDTO> Register([FromBody] LearnerDTO learner)
        {
            var registeredTrainee = _learnerService.Register(_mapper.Map<Learner>(learner));
            return Ok(_mapper.Map<LearnerDTO>(registeredTrainee));
        }

        [HttpPost("login")]
        public ActionResult<LearnerDTO> Login([FromBody] LoginDTO login)
        {
            try
            {
                var loggedInTrainee = _learnerService.Login(login.StudentIndex);
                return Ok(_mapper.Map<LearnerDTO>(loggedInTrainee));
            }
            catch (LearnerWithStudentIndexNotFound e)
            {
                return NotFound(e.Message);
            }
        }
    }
}