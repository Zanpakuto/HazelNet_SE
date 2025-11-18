using System;
using Kards.NET.Models;

namespace Kards.NET.Models;

public class ReviewLog
{
    public int CardId { get; set; }
    public DateTime DaOffset { get; set; }
    public Rating _Rating { get; set; }
    public State _State { get; set; }
    public DateTime Duration { get; set; }
    public DateTime ElapsedDays { get; set; }
    public DateTime ElapsedSeconds { get; set; }
}