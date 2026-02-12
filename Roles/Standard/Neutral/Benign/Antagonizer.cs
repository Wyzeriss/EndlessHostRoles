using System.Collections.Generic;
using AmongUs.GameOptions;

namespace EHR.Roles;

public class Antagonizer : RoleBase
{
    private const int Id = 643540;
    public static bool On;
    private static OptionItem KillCooldown;
    private static OptionItem NumberOfAntagonizeToWin;
    private static OptionItem CanVent;
    private static OptionItem HasImpVision;

        KillCooldown = new FloatOptionItem(Id + 4, "KillCooldown", new(0f, 180f, 0.5f), 22.5f, TabGroup.NeutralRoles)
            .SetParent(Options.CustomRoleSpawnChances[CustomRoles.Antagonizer])
            .SetValueFormat(OptionFormat.Seconds);

        NumberOfAntagonizeToWin = new FloatOptionItem(Id + 7, "NumberOfAntagonizeToWin", new(1f, 10f, 1f), 3f, TabGroup.NeutralRoles)
            .SetParent(Options.CustomRoleSpawnChances[CustomRoles.Antagonizer])

        CanVent = new BooleanOptionItem(Id + 5, "CanVent", true, TabGroup.NeutralRoles)
            .SetParent(Options.CustomRoleSpawnChances[CustomRoles.Antagonizer]);

        HasImpVision = new BooleanOptionItem(Id + 6, "ImpostorVision", false, TabGroup.NeutralRoles)
            .SetParent(Options.CustomRoleSpawnChances[CustomRoles.Antagonizer]);
    }
