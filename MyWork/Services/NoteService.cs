using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using MyWork.Abstractions.Services;
using MyWork.Models;

namespace MyWork.Services
{
    public class NoteService : INoteService
    {
        public List<Note> ReadFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл с записями по заданному пути не найден");

            var text = File.ReadAllText(path);
            var notes = JsonSerializer.Deserialize<List<Note>>(text);

            return notes;
        }

        public void Save(List<Note> notes, string path)
        {
            var json = JsonSerializer.Serialize(notes);

            File.WriteAllText(path, json);
        }
    }
}
