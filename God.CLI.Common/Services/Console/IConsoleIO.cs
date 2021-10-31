using System;

namespace God.CLI.Common.Services.Console {
  public interface IConsoleIO {
    void Clear();
    void Write(string text);
    void WriteHighlight(string text);
    void WriteToRow(int rowIndex, string text);
    void WriteLine(string text);
    string ReadLine();
    ConsoleKeyInfo ReadKey();
    int GetHeight();
    
  }
}