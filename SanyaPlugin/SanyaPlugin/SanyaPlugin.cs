﻿using System;
using System.Collections.Generic;
using Smod2;
using Smod2.API;
using Smod2.Attributes;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.Config;

namespace SanyaPlugin
{
    [PluginDetails(
    author = "sanyae2439",
    name = "SanyaPlugin",
    description = "nya",
    id = "sanyae2439.sanyaplugin",
    version = "8.0",
    SmodMajor = 3,
    SmodMinor = 1,
    SmodRevision = 18
    )]

    class SanyaPlugin : Plugin

    {
        public override void OnDisable()
        {

        }

        public override void OnEnable()
        {
            this.Info("さにゃぷらぐいん Loaded [Ver" + this.Details.version + "]");
            this.Info("ずりずり");
        }

        public override void Register()
        {
            //EventHandler
            this.AddEventHandlers(new EventHandler(this));

            //小物系
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_escape_spawn", true, Smod2.Config.SettingType.BOOL, true, "sanya_escape_spawn"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_infect_by_scp049_2", true, Smod2.Config.SettingType.BOOL, true, "sanya_infect"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_infect_limit_time", 4, Smod2.Config.SettingType.NUMERIC, true, "sanya_infect_limit_time"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_warhead_dontlock", true, Smod2.Config.SettingType.BOOL, true, "sanya_warhead_dontlock"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_pocket_cleanup", false, Smod2.Config.SettingType.BOOL, true, "sanya_pocket_cleanup"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_traitor_enabled", false, Smod2.Config.SettingType.BOOL, true, "sanya_traitor_enabled"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_traitor_limitter", 4, Smod2.Config.SettingType.NUMERIC, true, "sanya_traitor_limitter"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_traitor_chance_percent", 50, Smod2.Config.SettingType.NUMERIC, true, "sanya_traitor_chance_percent"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp079_enabled", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp079_enabled"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp079_doors_interval", 30, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp079_doors_interval"));

            //SCPごとの回復間隔&回復値
            var durationsdic = new Dictionary<string, string>()
            {
                {"SCP173","-1" },
                {"SCP106","-1" },
                {"SCP049","-1" },
                {"SCP049_2","-1" },
                {"SCP096","-1" },
                {"SCP939","-1" },
            };
            var amountsdic = new Dictionary<string, string>()
            {
                {"SCP173","-1" },
                {"SCP106","-1" },
                {"SCP049","-1" },
                {"SCP049_2","-1" },
                {"SCP096","-1" },
                {"SCP939","-1" },
            };
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp_recovery_durations", durationsdic, Smod2.Config.SettingType.DICTIONARY, true, "sanya_scp_recovery_durations"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp_recovery_amounts", amountsdic, Smod2.Config.SettingType.DICTIONARY, true, "sanya_scp_recovery_amounts"));

            //複製config   
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp173_duplicate_hp", -1, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp173_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_duplicate_hp", -1, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp049_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_2_duplicate_hp", -1, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp049_2_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp939_duplicate_hp", -1, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp939_duplicate_hp"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp106_duplicate_hp", -1, Smod2.Config.SettingType.NUMERIC, true, "sanya_scp106_duplicate_hp"));

            //旧config
            /*
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp173_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp173_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp049_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp049_2_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp049_2_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp939_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp939_duplicate"));
            this.AddConfig(new Smod2.Config.ConfigSetting("sanya_scp106_duplicate", false, Smod2.Config.SettingType.BOOL, true, "sanya_scp106_duplicate"));
            */
        }
    }
}
