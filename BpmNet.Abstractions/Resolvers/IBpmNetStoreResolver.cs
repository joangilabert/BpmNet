﻿using BpmNet.Model;
using BpmNet.Stores;

namespace BpmNet.Resolvers
{
    public interface IBpmNetStoreResolver
    {
        IBpmNetProcessInstanceStore<TInstance, TInstanceFlow> GetProcessInstanceStore<TInstance, TInstanceFlow>()
            where TInstance : class, IProcessInstance<TInstanceFlow>
            where TInstanceFlow : class, IBpmNetInstanceFlow;

        IBpmNetDefinitionStore<TDefinition> GetDefinitionStore<TDefinition>()
            where TDefinition : class, IBpmNetDefinition;

        IBpmNetProcessStore<TProcess> GetProcessStore<TProcess>()
            where TProcess : class, IBpmNetProcess;

        IBpmNetHistoryStore<THistory> GetHistoryStore<THistory>()
            where THistory : class, IBpmNetHistory;
    }
}
