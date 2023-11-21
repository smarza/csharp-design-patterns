namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public class Exercise : BaseExercise
{
    ConversionTaskHandler begin;

    public Exercise() : base()
    {
        CreateWorkFlow();
    }

    public override void Execute()
    {
        foreach (var conversionTask in SeedConversionTasks())
        {
            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine($"Verificando Tarefa: {conversionTask.Name}: \n");

            // Inicia o processamento
            begin.Handle(conversionTask);
        }
    }

    private void CreateWorkFlow()
    {
        // Instancia todos os handlers
        begin = new BeginHandler();

        // Encerramento
        var finish = new FinishHandler();

        // Fluxo de Jobs
        var conversionJobsWorkflow = new ConversionJobsWorkflowHandler();

        // Instancias dos Condicionais
        var checkProjectState = new CheckProjectStateHandler();
        var checkConversionJobState = new CheckConversionJobStateHandler();
        var checkAssociatedFiles = new CheckAssociatedFilesHandler();
        var checkFilesInInputFolder = new CheckFilesInInputFolderHandler();
        var checkRemoveEmptyTaskFlag = new CheckRemoveEmptyTaskFlagHandler();
        var checkMultipleProjects = new CheckMultipleProjectsHandler();
        var checkHashChange = new CheckHashChangeHandler();

        // Instancias das Ações
        var updateStateToUpdating = new UpdateStateToUpdatingHandler();
        var calculateTaskHash = new CalculateTaskHashHandler();
        var updateStateToInvalid = new UpdateStateToInvalidHandler();
        var deleteTask = new DeleteTaskHandler();
        var removeProjectAssociation = new RemoveProjectAssociationHandler();
        var updateHash = new UpdateHashHandler();
        var updateStateToQueued = new UpdateStateToQueuedHandler();
        var updateStateToValid = new UpdateStateToValidHandler();

        // ---------------------
        // Configura o fluxo

        begin.SetNextOnTrue(checkProjectState);

        // Referências dos Condicionais

        // O projeto associado está no estado 'Atualizando' ?
        checkProjectState
            .SetNextOnTrue(finish)
            .SetNextOnFalse(checkConversionJobState);

        // Algum 'Conversion Job' associado está em estado inapropriado?
        checkConversionJobState
            .SetNextOnTrue(finish)
            .SetNextOnFalse(updateStateToUpdating);

        // Muda o estado para 'Atualizando'.
        updateStateToUpdating
            .SetNextOnTrue(checkAssociatedFiles);

        // A tarefa tem arquivos associados?
        checkAssociatedFiles
            .SetNextOnTrue(checkFilesInInputFolder)
            .SetNextOnFalse(checkRemoveEmptyTaskFlag);

        // Os arquivos da tarefa estão presentes na pasta de entrada?
        checkFilesInInputFolder
            .SetNextOnTrue(calculateTaskHash)
            .SetNextOnFalse(updateStateToInvalid);

        // A flag 'RemoveEmptyTask' do projeto está verdadeira?
        checkRemoveEmptyTaskFlag
            .SetNextOnTrue(checkMultipleProjects)
            .SetNextOnFalse(updateStateToInvalid);

        // A Tarefa possui mas de um projeto?
        checkMultipleProjects
            .SetNextOnTrue(removeProjectAssociation)
            .SetNextOnFalse(deleteTask);

        // O hash da Tarefa mudou?
        checkHashChange
            .SetNextOnTrue(updateHash)
            .SetNextOnFalse(conversionJobsWorkflow);

        // ---------------------
        // Referências das Ações

        // Muda o estado para 'Inválido'.
        updateStateToInvalid.SetNextOnTrue(finish);

        // Apaga a tarefa.
        deleteTask.SetNextOnTrue(finish);

        // Remove a associação do projeto.
        removeProjectAssociation.SetNextOnTrue(finish);

        // Calcula o hash da tarefa.
        calculateTaskHash.SetNextOnTrue(checkHashChange);

        // Atualiza o Hash.
        updateHash.SetNextOnTrue(updateStateToQueued);

        // Muda o estado de todas as 'Conversion Jobs' associadas para 'Na Fila de Conversão'.
        updateStateToQueued.SetNextOnTrue(updateStateToValid);

        // Muda o estado para 'Válido'.
        updateStateToValid.SetNextOnTrue(finish);

        // Fluxo externo (mock)
        conversionJobsWorkflow.SetNextOnTrue(updateStateToValid);
    }

    private List<ConversionTask> SeedConversionTasks()
    {
        var results = new List<ConversionTask>();

        var project1 = new Project("PROJ_1") { Status = ProjectStatus.Idle };
        var project2 = new Project("PROJ_2") { Status = ProjectStatus.Updated };
        var project3 = new Project("PROJ_3") { Status = ProjectStatus.Updating };
        var project4 = new Project("PROJ_4") { Status = ProjectStatus.Error };
        var project5 = new Project("PROJ_5") { Status = ProjectStatus.GeneratingCadModels };

        var file1 = new ProjectFile("FILE_1") { };
        var file2 = new ProjectFile("FILE_2") { };
        var file3 = new ProjectFile("FILE_3") { };

        var job1 = new ConversionJob("JOB_1") { JobStatus = ConversionJobStatus.Idle };
        var job2 = new ConversionJob("JOB_2") { JobStatus = ConversionJobStatus.Enqueued };
        var job3 = new ConversionJob("JOB_3") { JobStatus = ConversionJobStatus.WaitingForResource };
        var job4 = new ConversionJob("JOB_4") { JobStatus = ConversionJobStatus.Converting };
        var job5 = new ConversionJob("JOB_5") { JobStatus = ConversionJobStatus.Converted };
        var job6 = new ConversionJob("JOB_6") { JobStatus = ConversionJobStatus.Cancelled };
        var job7 = new ConversionJob("JOB_7") { JobStatus = ConversionJobStatus.Error };

        results.Add(new ConversionTask("TASK_1") { Projects = new List<Project>() { project1 }, Jobs = new List<ConversionJob>() { job1 }, Files = new List<ProjectFile>() { file1 } });
        results.Add(new ConversionTask("TASK_2") { Projects = new List<Project>() { project2 }, Jobs = new List<ConversionJob>() { job2 }, Files = new List<ProjectFile>() { file1 } });
        results.Add(new ConversionTask("TASK_3") { Projects = new List<Project>() { project3 }, Jobs = new List<ConversionJob>() { job3 }, Files = new List<ProjectFile>() { file1 } });
        results.Add(new ConversionTask("TASK_4") { Projects = new List<Project>() { project4 }, Jobs = new List<ConversionJob>() { job4 }, Files = new List<ProjectFile>() { file1 } });
        results.Add(new ConversionTask("TASK_5") { Projects = new List<Project>() { project5 }, Jobs = new List<ConversionJob>() { job5 }, Files = new List<ProjectFile>() { file1 } });
        results.Add(new ConversionTask("TASK_6") { Projects = new List<Project>() { project1, project2 }, Jobs = new List<ConversionJob>() { job6 }, Files = new List<ProjectFile>() { file1 } });
        results.Add(new ConversionTask("TASK_7") { Projects = new List<Project>() { project3, project4 }, Jobs = new List<ConversionJob>() { job7 }, Files = new List<ProjectFile>() { file1 } });

        results.Add(new ConversionTask("TASK_8") { Status = ConversionTaskStatus.Unverified });
        results.Add(new ConversionTask("TASK_9") { Status = ConversionTaskStatus.Valid });
        results.Add(new ConversionTask("TASK_10") { Status = ConversionTaskStatus.Invalid });

        return results;
    }

}
