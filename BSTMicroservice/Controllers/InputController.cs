using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSTMicroservice.Classes;
using BSTMicroservice.Sevices;


namespace BSTMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BSTMController : ControllerBase
    {
        private readonly IBinaryTreeCreation _binaryTreeCreation;

        public BSTMController(IBinaryTreeCreation binaryTreeCreation)
        {
            _binaryTreeCreation = binaryTreeCreation;
        }


        [HttpPost]
        public IActionResult Post(int key, string data)
        {
            Node root = new Node(10, "Denmark");
            var tree = _binaryTreeCreation.Creation(root);
            tree.insert(key, data);
            return Ok(tree);
        }
    }
}
