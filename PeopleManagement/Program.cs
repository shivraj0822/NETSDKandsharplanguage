// CsvParser parser = new();
// parser.Parse();
// parser.PrintNames();

CsvParser parser = new CsvParser();
List<Person> people = parser.Parse();


PeopleReport report = new PeopleReport();


report.SaveMales(people.ToArray(), "males.csv");
report.SaveAdultFemales(people.ToArray(), "adultfemales.csv");
report.SaveDotComUsers(people.ToArray(), "dotcomusers.csv");