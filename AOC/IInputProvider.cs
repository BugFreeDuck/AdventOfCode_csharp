﻿namespace AOC.Solvers;

public interface IInputProvider
{
    IEnumerable<string> LineByLine(short year, short day);
    IEnumerable<char> CharByChar(short year, short day);
}
