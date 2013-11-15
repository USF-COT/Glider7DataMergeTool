using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Glider7DataMergeTool
{
    public class Glider7DataFile
    {
        private String path;
        private String timeHeader;

        private StreamReader stream;
        public StreamReader Stream
        {
            get { return this.stream; }
        }

        private UInt16 timeIndex;
        public UInt16 TimeIndex
        {
            get { return this.timeIndex; }
        }

        private int numCols;

        private String headers;
        public String Headers
        {
            get { return this.headers; }
        }

        private string units;
        public String Units
        {
            get { return this.units; }
        }

        public Glider7DataFile(String path, String timeHeader)
        {
            this.path = path;
            this.timeHeader = timeHeader;
        }

        public void openDataFile(){
            this.stream = new StreamReader(path);

            // Find Header
            String line = "";
            do
            {
                line = this.stream.ReadLine();
            } while (!line.Contains(this.timeHeader) && !this.stream.EndOfStream);

            if (this.stream.EndOfStream)
            {
                throw new IOException("Could not find time header(" + timeHeader + ") in file @: " + path);
            }
            this.headers = line;

            // Grab Next Line as Units
            this.units = this.stream.ReadLine();

            // Throw out next two lines which contain sampling frequency and statistics
            this.stream.ReadLine();
            this.stream.ReadLine();

            // Find Time Header Index
            this.headers = this.headers.Trim();
            String[] headerArray = this.headers.Split(' ');
            this.numCols = headerArray.Length;
            for (UInt16 i = 0; i < headerArray.Length; i++)
            {
                if (headerArray[i].Equals(this.timeHeader))
                {
                    this.timeIndex = i;
                }
            }
        }

        public void closeDataFile()
        {
            this.stream.Close();
        }

        public Glider7Reading getNextReading()
        {
            if (!this.stream.EndOfStream)
            {
                String line = this.stream.ReadLine();
                String[] lineArray = line.Split(' ');
                double time = Double.Parse(lineArray[this.timeIndex]);

                return new Glider7Reading(time, line);
            }
            else
            {
                return null;
            }
        }

        public Glider7Reading getNaNReading(double time)
        {
            String nanLine = "";

            for (int i = 0; i < numCols; i++)
            {
                if (i == this.timeIndex)
                {
                    nanLine += time.ToString() + " ";
                }
                else
                {
                    nanLine = nanLine + "NaN ";
                }
            }
            return new Glider7Reading(time, nanLine);
        }
        
    }
}
