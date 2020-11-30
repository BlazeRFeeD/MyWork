using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MyWork.Abstractions.Services;
using MyWork.Models;

namespace MyWork.Services
{
    public class UserProfileService : IUserProfileService
    {
        public UserProfile ReadFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл с профилем по заданному пути не найден");

            var text = File.ReadAllText(path);
            var profile = JsonSerializer.Deserialize<UserProfile>(text);

            return profile;
        }

        public void Save(UserProfile userProfile, string path)
        {
            var json = JsonSerializer.Serialize(userProfile);

            File.WriteAllText(path, json);
        }
    }
}
