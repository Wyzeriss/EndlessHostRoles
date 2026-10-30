namespace EHR;

public class PresetOptionItem(int defaultValue, TabGroup tab) : OptionItem(0, "Preset", defaultValue, tab, true)
{
    public readonly IntegerValueRule Rule = (0, NumPresets - 1, 1);

    // Getter
    public override int GetInt()
    {
        return Rule.GetValueByIndex(CurrentValue);
    }

    public override float GetFloat()
    {
        return Rule.GetValueByIndex(CurrentValue);
    }

    public override string GetString()
    {
        return CurrentValue switch
        {
            0 => Main.Preset1.Value == (string)Main.Preset1.DefaultValue ? Translator.GetString("Preset_1") : Main.Preset1.Value,
            1 => Main.Preset2.Value == (string)Main.Preset2.DefaultValue ? Translator.GetString("Preset_2") : Main.Preset2.Value,
            2 => Main.Preset3.Value == (string)Main.Preset3.DefaultValue ? Translator.GetString("Preset_3") : Main.Preset3.Value,
            3 => Main.Preset4.Value == (string)Main.Preset4.DefaultValue ? Translator.GetString("Preset_4") : Main.Preset4.Value,
            4 => Main.Preset5.Value == (string)Main.Preset5.DefaultValue ? Translator.GetString("Preset_5") : Main.Preset5.Value,
            5 => Main.Preset6.Value == (string)Main.Preset6.DefaultValue ? Translator.GetString("Preset_6") : Main.Preset6.Value,
            6 => Main.Preset7.Value == (string)Main.Preset7.DefaultValue ? Translator.GetString("Preset_7") : Main.Preset7.Value,
            7 => Main.Preset8.Value == (string)Main.Preset8.DefaultValue ? Translator.GetString("Preset_8") : Main.Preset8.Value,
            8 => Main.Preset9.Value == (string)Main.Preset9.DefaultValue ? Translator.GetString("Preset_9") : Main.Preset9.Value,
            9 => Main.Preset10.Value == (string)Main.Preset10.DefaultValue ? Translator.GetString("Preset_10") : Main.Preset10.Value,
            10 => Main.Preset11.Value == (string)Main.Preset11.DefaultValue ? Translator.GetString("Preset_11") : Main.Preset11.Value,
            11 => Main.Preset12.Value == (string)Main.Preset12.DefaultValue ? Translator.GetString("Preset_12") : Main.Preset12.Value,
            12 => Main.Preset13.Value == (string)Main.Preset13.DefaultValue ? Translator.GetString("Preset_13") : Main.Preset13.Value,
            13 => Main.Preset14.Value == (string)Main.Preset14.DefaultValue ? Translator.GetString("Preset_14") : Main.Preset14.Value,
            14 => Main.Preset15.Value == (string)Main.Preset15.DefaultValue ? Translator.GetString("Preset_15") : Main.Preset15.Value,
            15 => Main.Preset16.Value == (string)Main.Preset16.DefaultValue ? Translator.GetString("Preset_16") : Main.Preset16.Value,
            16 => Main.Preset17.Value == (string)Main.Preset17.DefaultValue ? Translator.GetString("Preset_17") : Main.Preset17.Value,
            17 => Main.Preset18.Value == (string)Main.Preset18.DefaultValue ? Translator.GetString("Preset_18") : Main.Preset18.Value,
            18 => Main.Preset19.Value == (string)Main.Preset19.DefaultValue ? Translator.GetString("Preset_19") : Main.Preset19.Value,
            19 => Main.Preset20.Value == (string)Main.Preset20.DefaultValue ? Translator.GetString("Preset_20") : Main.Preset20.Value,
            20 => Main.Preset21.Value == (string)Main.Preset21.DefaultValue ? Translator.GetString("Preset_21") : Main.Preset21.Value,
            21 => Main.Preset22.Value == (string)Main.Preset22.DefaultValue ? Translator.GetString("Preset_22") : Main.Preset22.Value,
            22 => Main.Preset23.Value == (string)Main.Preset23.DefaultValue ? Translator.GetString("Preset_23") : Main.Preset23.Value,
            23 => Main.Preset24.Value == (string)Main.Preset24.DefaultValue ? Translator.GetString("Preset_24") : Main.Preset24.Value,
            24 => Main.Preset25.Value == (string)Main.Preset25.DefaultValue ? Translator.GetString("Preset_25") : Main.Preset25.Value,
            25 => Main.Preset26.Value == (string)Main.Preset26.DefaultValue ? Translator.GetString("Preset_26") : Main.Preset26.Value,
            26 => Main.Preset27.Value == (string)Main.Preset27.DefaultValue ? Translator.GetString("Preset_27") : Main.Preset27.Value,
            27 => Main.Preset28.Value == (string)Main.Preset28.DefaultValue ? Translator.GetString("Preset_28") : Main.Preset28.Value,
            28 => Main.Preset29.Value == (string)Main.Preset29.DefaultValue ? Translator.GetString("Preset_29") : Main.Preset29.Value,
            29 => Main.Preset30.Value == (string)Main.Preset30.DefaultValue ? Translator.GetString("Preset_30") : Main.Preset30.Value,
            30 => Main.Preset31.Value == (string)Main.Preset31.DefaultValue ? Translator.GetString("Preset_31") : Main.Preset31.Value,
            31 => Main.Preset32.Value == (string)Main.Preset32.DefaultValue ? Translator.GetString("Preset_32") : Main.Preset32.Value,
            32 => Main.Preset33.Value == (string)Main.Preset33.DefaultValue ? Translator.GetString("Preset_33") : Main.Preset33.Value,
            33 => Main.Preset34.Value == (string)Main.Preset34.DefaultValue ? Translator.GetString("Preset_34") : Main.Preset34.Value,
            34 => Main.Preset35.Value == (string)Main.Preset35.DefaultValue ? Translator.GetString("Preset_35") : Main.Preset35.Value,
            35 => Main.Preset36.Value == (string)Main.Preset36.DefaultValue ? Translator.GetString("Preset_36") : Main.Preset36.Value,
            36 => Main.Preset37.Value == (string)Main.Preset37.DefaultValue ? Translator.GetString("Preset_37") : Main.Preset37.Value,
            37 => Main.Preset38.Value == (string)Main.Preset38.DefaultValue ? Translator.GetString("Preset_38") : Main.Preset38.Value,
            38 => Main.Preset39.Value == (string)Main.Preset39.DefaultValue ? Translator.GetString("Preset_39") : Main.Preset39.Value,
            39 => Main.Preset40.Value == (string)Main.Preset40.DefaultValue ? Translator.GetString("Preset_40") : Main.Preset40.Value,
            40 => Main.Preset41.Value == (string)Main.Preset41.DefaultValue ? Translator.GetString("Preset_41") : Main.Preset41.Value,
            41 => Main.Preset42.Value == (string)Main.Preset42.DefaultValue ? Translator.GetString("Preset_42") : Main.Preset42.Value,
            42 => Main.Preset43.Value == (string)Main.Preset43.DefaultValue ? Translator.GetString("Preset_43") : Main.Preset43.Value,
            43 => Main.Preset44.Value == (string)Main.Preset44.DefaultValue ? Translator.GetString("Preset_44") : Main.Preset44.Value,
            44 => Main.Preset45.Value == (string)Main.Preset45.DefaultValue ? Translator.GetString("Preset_45") : Main.Preset45.Value,
            45 => Main.Preset46.Value == (string)Main.Preset46.DefaultValue ? Translator.GetString("Preset_46") : Main.Preset46.Value,
            46 => Main.Preset47.Value == (string)Main.Preset47.DefaultValue ? Translator.GetString("Preset_47") : Main.Preset47.Value,
            47 => Main.Preset48.Value == (string)Main.Preset48.DefaultValue ? Translator.GetString("Preset_48") : Main.Preset48.Value,
            48 => Main.Preset49.Value == (string)Main.Preset49.DefaultValue ? Translator.GetString("Preset_49") : Main.Preset49.Value,
            49 => Main.Preset50.Value == (string)Main.Preset50.DefaultValue ? Translator.GetString("Preset_50") : Main.Preset50.Value,
            _ => null
        };
    }

    public override int GetValue()
    {
        return Rule.RepeatIndex(base.GetValue());
    }

    // Setter
    public override void SetValue(int value, bool doSync = true)
    {
        base.SetValue(Rule.RepeatIndex(value), doSync);
        SwitchPreset(Rule.RepeatIndex(value));
    }

}
