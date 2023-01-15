using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace kursach1
{
    public class RecordsTable
    {
        private readonly LinkedList<SinglePlayerResult> _recordsTable = new LinkedList<SinglePlayerResult>();

        public void ReadRecordsTable()
        {
            try
            {
                using (var reader =
                       new BinaryReader(File.Open("Other\\RecordsOfPlayers", FileMode.OpenOrCreate)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        var nick = reader.ReadString();
                        var points = reader.ReadUInt32();
                        _recordsTable.AddLast(new SinglePlayerResult(nick, points));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string getSinglePlayer(int ind)
        {
            if (ind < _recordsTable.Count)
                return _recordsTable.ToArray()[ind].ToString();
            return "-";
        }

        public void ChangeRecordsTable(string nick, uint points)
        {
            if (_recordsTable.Count == 0)
            {
                _recordsTable.AddFirst(new SinglePlayerResult(nick, points));
                return;
            }

            if (_recordsTable.Last.Value.score >= points && _recordsTable.Count == 10)
                return;
            var node = _recordsTable.First;
            var i = 1;
            do
            {
                if (node.Value.score < points)
                    break;
                i++;
                node = node.Next;
            } while (node != null);

            if (node != null)
                _recordsTable.AddBefore(node, new SinglePlayerResult(nick, points));
            else if (_recordsTable.Count == i - 1 && _recordsTable.Count < 10)
                _recordsTable.AddLast(new SinglePlayerResult(nick, points));
            while (_recordsTable.Count > 10)
                _recordsTable.RemoveLast();
        }

        public int getCount()
        {
            return _recordsTable.Count;
        }

        public void WriteRecordsTable()
        {
            try
            {
                using (var writer =
                       new BinaryWriter(File.Open("Other\\RecordsOfPlayers", FileMode.OpenOrCreate)))
                {
                    foreach (var item in _recordsTable)
                    {
                        writer.Write(item.userName);
                        writer.Write(item.score);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}