﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee
        public IActionResult Index()
        {
            var applicationDbContext = _context.Employees.Include(e => e.IdentityUser);
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
            if (employee == null)
            {
                return RedirectToAction(nameof(Create));
            }
            return RedirectToAction(nameof(DisplayCustomers));
        }
        public IActionResult DisplayCustomers()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int zip = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault().ZipCode;
            var customersInZip = _context.Customers.Where(c => c.ZipCode.Equals(zip));
            List<Customer> applicationDbContext = new List<Customer>();
            foreach (var customer in customersInZip)
            {
                if (customer.PickUpDay.Equals(DateTime.Today.DayOfWeek)) 
                { 
                    applicationDbContext.Add(customer); 
                }
            }

            return View(applicationDbContext);
        }
        [HttpPost]
        public IActionResult AddToPIckUp(IEnumerable<Customer> customers)
        {
            List<PickUp> pickUps = new List<PickUp>();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employees.Where(e => e.IdentityUserId == userId).Single();
            DateTime date = DateTime.Today;
            foreach (Customer customer in customers)
            {
                if (customer.IsComplete == true)
                {
                    pickUps.Add(new PickUp() { Paid = false, Date = date, CustomerId = customer.CustomerId, EmployeeId = employee.EmployeeId });
                }
            }
            foreach (PickUp pickUp in pickUps)
            {
                _context.PickUps.Add(pickUp);
            }
            return RedirectToAction(nameof(Index));
        }
        // GET: customers by specific date - Possibly unnessicary
        
        public IActionResult GetDate()
        {
            return View();
        }
        //
        public IActionResult DisplaySelectedCustomers(Employee employee)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int zip = _context.Employees.Where(e => e.IdentityUserId == userId).FirstOrDefault().ZipCode;
            var customersInZip = _context.Customers.Where(c => c.ZipCode.Equals(zip));
            List<Customer> applicationDbContext = new List<Customer>();
            foreach (var customer in customersInZip)
            {
                if (customer.PickUpDay.Equals(employee.DayOfWeek)) { applicationDbContext.Add(customer); }
            }

            return View(applicationDbContext);
        }
        // GET: Employee/Details/5
        public async Task<IActionResult> Details()
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,ZipCode,IdentityUserId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,ZipCode,IdentityUserId")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
