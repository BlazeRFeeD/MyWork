using System;
using System.Collections.Generic;
using System.Text;
using MyWork.Models;

namespace MyWork.Abstractions.Services
{
    public interface INoteService
    {
        List<Note> ReadFromFile(string path);

        void Save(List<Note> notes, string path);

    }
}
