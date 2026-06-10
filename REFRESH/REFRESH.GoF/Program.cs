using REFRESH.GoF.Structural._04_Decorator;

const bool facebookEnabled = true;
const bool slackEnabled = true;
const bool smsEnabled = true;

var stack = new Notifier();
if (smsEnabled)
{
    stack = new SMSDecorator(stack);
}
if (facebookEnabled)
{
    stack = new FacebookDecorator(stack);
}
if (slackEnabled)
{
    stack = new SlackDecorator(stack);
}

stack.SendMessage("Hi yall");