namespace MiningManager.Messengers
{
    /// <summary>
    /// Utilisez une énumération pour les messages pour assurer la cohérence 
    /// </summary>
    public enum MessageTypes
    {
        MSG_COMMAND_MENU_FINDERMGR,                 // Appel de la fenetre de Finder manager
        MSG_COMMAND_MENU_EXCAVATORMGR,              // Appel de la fenetre de Excavator manager
        MSG_COMMAND_MENU_REFINERMGR,                // Appel de la fenetre de Refiner manager
        MSG_COMMAND_MENU_FINDERAMPLIFIERMGR,        // Appel de la fenetre de FinderAmplifier manager
        MSG_COMMAND_ITEMMANAGER_UPDATEBUTTON,
        MSG_COMMAND_ITEMMANAGER_CREATEBUTTON,
        MSG_COMMAND_ITEMMANAGER_SUBMITBUTTON,
        MSG_COMMAND_ITEMMANAGER_CANCELBUTTON,
        MSG_MANAGER_EDIT,
        MSG_MANAGER_SAVE

    };
}
