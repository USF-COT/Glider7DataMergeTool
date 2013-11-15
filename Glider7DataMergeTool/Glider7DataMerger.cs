using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Glider7DataMergeTool
{
    public class Glider7DataMerger
    {
        Glider7DataFile flightFile;
        Glider7DataFile scienceFile;

        public Glider7DataMerger(Glider7DataFile flightFile, Glider7DataFile scienceFile)
        {
            this.flightFile = flightFile;
            this.scienceFile = scienceFile;
        }

        public void mergeDataTo(String outputPath)
        {
            Glider7Reading flightRead = null;
            Glider7Reading sciRead = null;
            StreamWriter outWriter = new StreamWriter(outputPath);

            // Open Data Files
            this.flightFile.openDataFile();
            this.scienceFile.openDataFile();

            // Write Headers to Out File
            outWriter.WriteLine(this.flightFile.Headers + " " + this.scienceFile.Headers);
            outWriter.WriteLine(this.flightFile.Units + " " + this.scienceFile.Units);

            // Merge Readings
            flightRead = this.flightFile.getNextReading();
            sciRead = this.scienceFile.getNextReading();

            while (flightRead != null || sciRead != null)
            {
                // Fill in null readings
                if (flightRead == null)
                {
                    flightRead = this.flightFile.getNaNReading(sciRead.Time);
                }
                else if (sciRead == null)
                {
                    sciRead = this.scienceFile.getNaNReading(flightRead.Time);
                }

                // Write out a line and move to the next set
                if (Math.Abs(flightRead.Time - sciRead.Time) < 1)
                {
                    outWriter.WriteLine(flightRead.Line + " " + sciRead.Line);
                    flightRead = this.flightFile.getNextReading();
                    sciRead = this.scienceFile.getNextReading();
                }
                else if (flightRead.Time > sciRead.Time)
                {
                    Glider7Reading flightNAN = this.flightFile.getNaNReading(sciRead.Time);
                    outWriter.WriteLine(flightNAN.Line + " " + sciRead.Line);
                    sciRead = this.scienceFile.getNextReading();
                }
                else // (flightRead.Time < sciRead.Time)
                {
                    Glider7Reading sciNAN = this.scienceFile.getNaNReading(flightRead.Time);
                    outWriter.WriteLine(flightRead.Line + " " + sciNAN.Line);
                    flightRead = this.flightFile.getNextReading();
                }
            }

            // housekeeping!
            this.flightFile.closeDataFile();
            this.scienceFile.closeDataFile();
            outWriter.Close();
        }
    }
}
