using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrivateLessons.Data;
using PrivateLessons.Models;
using Microsoft.AspNetCore.Session;


namespace PrivateLessons.Controllers
{
    public class LoginController : Controller
    {
       
        public static string userName;
        public static string Password;

       private readonly entitycoreContext _context;

        public LoginController(entitycoreContext context)
        {
            _context = context;
        }

        // GET: Login
       public async Task<IActionResult> Index(string xusername,string xpassword)
                   {
                              
                      if (!String.IsNullOrEmpty(xusername) && !String.IsNullOrEmpty(xpassword))
                           {
                                 userName=xusername;
                                 Password=xpassword;
                                  await Task.Delay(1);
                                  return RedirectToAction("Details");
                           
                            }
                              else
                                  {
                                     return View();
                                 }        
                   }

             
        // GET: Login/Details/5
        public async Task<IActionResult> Details()
        { 
            var users = await _context.users
                .FirstOrDefaultAsync(m => m.username ==userName && m.password==Password); 
            if (userName==null || Password==null)
                {
                return RedirectToAction("Index");
               }
               else if(users ==null){
                   return RedirectToAction("Index");
               }
        
             else{
             users = await _context.users
                .FirstOrDefaultAsync(m => m.username ==userName && m.password==Password);              
              return View(users);
              
             } 
          
        }




        // GET: Login/Create
        public IActionResult Create()
        {
            return View();
        }

      

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,username,password,f_name,l_name,email,type_id")] users users)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,username,password,f_name,l_name,email,type_id")] users users)
        {
            if (id != users.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!usersExists(users.id))
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
            return View(users);
        }

        // GET: Login/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.users
                .FirstOrDefaultAsync(m => m.id == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.users.FindAsync(id);
            _context.users.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool usersExists(int id)
        {
            return _context.users.Any(e => e.id == id);
        }
    }
}
