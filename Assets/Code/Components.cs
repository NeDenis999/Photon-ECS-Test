using Code;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using static Entitas.CodeGeneration.Attributes.EventTarget;


public class Mine : IComponent { }
    
public class ConnectButton : IComponent { }

public class CreateRoomButton : IComponent { }

public class Hero : IComponent { }

public class Spawner : IComponent { }

public class SpawnerCreatedHero : IComponent { }

public class SpawnPoints : IComponent { public Vector2[] Value; }

public class Prefab : IComponent { public GameObject Value; }

public class Speed : IComponent { public float Value; }

public class NickName : IComponent { public string Value; }

public class Rigidbody2DComponent : IComponent { public Rigidbody2D Value; }

[Input] 
public class Horizontal : IComponent { public float Value; }

[Event(Self)]
public class Position : IComponent { public Vector2 Value; }

[Event(Self)]
public class Pressed : IComponent { }

//Services
[Unique, Meta] 
public class Multiplayer : IComponent { public IMultiplayerService Value; }

[Unique, Meta] 
public class Coroutine : IComponent { public ICoroutineService Value; }
