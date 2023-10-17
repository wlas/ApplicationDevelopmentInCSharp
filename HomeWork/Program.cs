using HomeWork;

var father = new FamilyMember("Иван", Gender.Male, DateOnly.Parse("25.02.1988"));
var mother = new FamilyMember("Ольга", Gender.Female, DateOnly.Parse("02.04.1989"));
father.AddSpouse(mother);
mother.AddSpouse(father);

var child1 = new FamilyMember("Миша", Gender.Male, DateOnly.Parse("11.10.2018"));
child1.SetParents(father, mother);
father.AddChild(child1);
mother.AddChild(child1);

var child2 = new FamilyMember("Игорь", Gender.Male, DateOnly.Parse("12.05.2019"));
child2.SetParents(father, mother);
father.AddChild(child2);
mother.AddChild(child2);


var father2 = new FamilyMember("Саша", Gender.Male, DateOnly.Parse("05.07.1982"));
var mother2 = new FamilyMember("Света", Gender.Female, DateOnly.Parse("02.04.1986"));
father2.AddSpouse(mother2);
mother2.AddSpouse(father2);

father.SetParents(father2, mother2);
mother2.AddChild(father);
father2.AddChild(father);

mother = new FamilyMember("Ирина", Gender.Female, DateOnly.Parse("01.04.1981"));
father.AddSpouse(mother);
mother.AddSpouse(father);

var child3 = new FamilyMember("Тимур", Gender.Male, DateOnly.Parse("11.10.2018"));
child3.SetParents(father, mother);
father.AddChild(child3);
mother.AddChild(child3);

var child4 = new FamilyMember("Алла", Gender.Female, DateOnly.Parse("01.04.2014"));
child4.SetParents(father,mother);
father.AddChild(child4);
mother.AddChild(child4);

FamilyMember.PrintTree(father2);
