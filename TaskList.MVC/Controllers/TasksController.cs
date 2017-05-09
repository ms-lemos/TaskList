using System.Web.Mvc;
using TaskList.MVC.ViewModels;
using TaskList.Application.Interface;
using TaskList.MVC.ViewModels.Mappers;

namespace TaskList.MVC.Controllers
{
    public class TasksController : Controller
    {
        private readonly TaskMapper _mapper = new TaskMapper();
        private readonly ITaskAppService _service;

        public TasksController(ITaskAppService service)
        {
            _service = service;
        }

        // GET: Task
        public ActionResult Index()
        {
            return View(_mapper.ToViewModelList(_service.GetAllAsNoTracking()));
        }

        // GET: Task
        public ActionResult Excluidas()
        {
            return View(_mapper.ToViewModelList(_service.ObterTasksExcluidas()));
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View(_mapper.ToViewModel(_service.GetById(id)));
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create(TaskViewModel task)
        {
            if (!ModelState.IsValid) return View(task);
            
            _service.Add(_mapper.ToDomain(task));

            return RedirectToAction("Index");
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_mapper.ToViewModel(_service.GetById(id)));
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(TaskViewModel task)
        {
            if (!ModelState.IsValid) return View(task);
            
            _service.Update(_mapper.ToDomain(task));

            return RedirectToAction("Index");
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_mapper.ToViewModel(_service.GetById(id)));
        }

        // POST: Task/Delete/5
        [HttpPost]
        public ActionResult Delete(TaskViewModel task)
        {
            if (!ModelState.IsValid) return View(task);

            _service.Remove(_mapper.ToDomain(task));

            return RedirectToAction("Index");
        }
    }
}
