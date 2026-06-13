using REFRESH.GoF.Behavioral._10_Visitor;

var app = new Application(new XMLExportVisitor());
var shape = new CompoundShape();
shape.Add(new Dot());
shape.Add(new Circle());
shape.Add(new Rectangle());
app.Add(shape);
app.Export();