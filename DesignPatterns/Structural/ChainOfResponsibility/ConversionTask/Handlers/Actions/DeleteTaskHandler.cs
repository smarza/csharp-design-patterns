﻿namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class DeleteTaskHandler : WorkflowHandler
{

    public override void Handle(ConversionTask task)
    {
        Console.WriteLine($"Apaga a tarefa.");

        _nextHandlerOnTrue?.Handle(task);
    }

}
