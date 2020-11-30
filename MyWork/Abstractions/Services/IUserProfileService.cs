using System;
using System.Collections.Generic;
using System.Text;
using MyWork.Models;

namespace MyWork.Abstractions.Services
{
    public interface IUserProfileService
    {
        UserProfile ReadFromFile(string path);

        void Save(UserProfile userProfile, string path);
    }
}
