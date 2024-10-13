// © SS220, An EULA/CLA with a hosting restriction, full text: https://raw.githubusercontent.com/SerbiaStrong-220/space-station-14/master/CLA.txt
using Content.Shared.SS220.SuperMatter.Ui;

namespace Content.Server.SS220.SuperMatter;

[RegisterComponent]
public sealed partial class SuperMatterObserverComponent : SharedSuperMatterObserverComponent { }

/// <summary> We use this component to mark entities which can receiver </summary>
[RegisterComponent]
public sealed partial class SuperMatterObserverReceiverComponent : SharedSuperMatterObserverReceiverComponent { }
