string filePath =@"D:\intern\NETSDKandsharplanguage\PeopleManagement\People.csv";

 CSVParser csvParser = new CSVParser();
 csvParser.Parse(filePath);
 csvParser.PrintNames();
