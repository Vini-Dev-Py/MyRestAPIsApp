using Microsoft.EntityFrameworkCore;
using MyRestCarnes.Data.VO;
using MyRestCarnes.Model;
using MyRestCarnes.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MyRestCarnes.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySQLContext _context;

        private DbSet<User> dataset;

        public UserRepository(MySQLContext context)
        {
            _context = context;
            dataset = _context.Set<User>();
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users.FirstOrDefault(u => (u.FirstName == user.FirstName) && (u.Password == pass));
        }

        public User ValidateCredentials(string firstName)
        {
            return _context.Users.SingleOrDefault(u => (u.FirstName == firstName));
        }

        public bool RevokeToken(string firstName)
        {
            var user = _context.Users.SingleOrDefault(u => (u.FirstName == firstName));
            if (user is null) return false;
            user.RefreshToken = null;
            _context.SaveChanges();
            return true;
        }

        public User RefreshUserInfo(User user)
        {
            if (!_context.Users.Any(u => u.Id.Equals(user.Id))) return null;

            var result = _context.Users.SingleOrDefault(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
        public User FindByUsername(string username)
        {
            return _context.Users.SingleOrDefault(u => u.FirstName.Equals(username));
        }

        public List<User> FindAll()
        {
            return dataset.ToList();
        }
    }
}
