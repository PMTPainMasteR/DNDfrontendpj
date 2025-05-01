using MySqlConnector;

namespace DNDfrontendpj
{
    internal class infodao
    {
        string connectionString = "datasource=localhost;port=8889;username=TRPG_USER;password=TRPG_USER;database=mytrpg;";
        internal int signupasdm(userInfo newuser)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                int newRows = 0;

                // Generate a new UID
                MySqlCommand getMaxIdCmd = new MySqlCommand("SELECT COALESCE(MAX(UID), 0) + 1 FROM user", connect);
                long newUid = (long)getMaxIdCmd.ExecuteScalar();

                // Insert the new user into the user table
                MySqlCommand addUserCmd = new MySqlCommand("INSERT INTO user (UID) VALUES (@mUID)", connect);
                addUserCmd.Parameters.AddWithValue("@mUID", newUid);
                newRows += addUserCmd.ExecuteNonQuery();

                // Now use the same newUid for inserting into the dm table
                MySqlCommand cmd = new MySqlCommand("INSERT INTO dm (UID, DM, username, pass) VALUES (@UID, @DM, AES_ENCRYPT(@username, SHA2('secure', 256)), " +
                    "AES_ENCRYPT(@password, SHA2('secure', 256)))", connect);

                cmd.Parameters.AddWithValue("@UID", newUid); // Use newUid here
                cmd.Parameters.AddWithValue("@DM", newuser.DM);
                cmd.Parameters.AddWithValue("@username", newuser.username);
                cmd.Parameters.AddWithValue("@password", newuser.password);
                newRows += cmd.ExecuteNonQuery();

                connect.Close();
                return newRows;
            }
        }

        internal int signupasplayer(userInfo newuser)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                int newRows = 0;
                MySqlCommand getMaxIdCmd = new MySqlCommand("SELECT COALESCE(MAX(UID), 0) + 1 FROM user", connect);
                long newUid = (long)getMaxIdCmd.ExecuteScalar();

                MySqlCommand addUserID = new MySqlCommand("INSERT INTO user (UID) VALUES (@mUID)", connect);
                addUserID.Parameters.AddWithValue("@mUID", newUid);
                newRows += addUserID.ExecuteNonQuery();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO player (UID, Player, username, pass) VALUES (@UID, @Player,AES_ENCRYPT(@username, SHA2('secure', 256)), " +
                    "AES_ENCRYPT(@password, SHA2('secure', 256)))", connect);

                cmd.Parameters.AddWithValue("@UID", newUid);
                cmd.Parameters.AddWithValue("@Player", newuser.Player);
                cmd.Parameters.AddWithValue("@username", newuser.username);
                cmd.Parameters.AddWithValue("@password", newuser.password);

                newRows = cmd.ExecuteNonQuery();
                connect.Close();
                Console.WriteLine($"Inserted Player UID: {newUid}");
                return newRows;
            }
        }
        internal int? isDM(string username, string password)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                string query = "SELECT UID FROM dm WHERE " +
                               "AES_DECRYPT(username, SHA2('secure', 256)) = @username AND " +
                               "AES_DECRYPT(pass, SHA2('secure', 256)) = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int?)Convert.ToInt64(result) : null;
                }
            }
        }
        internal int? isPlayer(string username, string password)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                string query = "SELECT UID FROM player WHERE " +
                               "AES_DECRYPT(username, SHA2('secure', 256)) = @username AND " +
                               "AES_DECRYPT(pass, SHA2('secure', 256)) = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int?)Convert.ToInt64(result) : null;
                }
            }
        }
        internal List<DM_campaign_info> getAllDMCampaign(int uid)
        {
            List<DM_campaign_info> campaign_info_try = new List<DM_campaign_info>();
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM campaign WHERE DMID = @DMID", connect);
                cmd.Parameters.AddWithValue("@DMID", uid);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DM_campaign_info ret = new DM_campaign_info()
                        {
                            CampaignID = reader.GetInt32(0),
                            CampaignName = reader.GetString(1),
                            Genre = reader.GetString(2),
                            Status = reader.GetString(3),
                            DMID = reader.GetInt32(4),
                            CampaignDescription = reader.GetString(5)
                        };
                        campaign_info_try.Add(ret);
                    }
                }
            }
            return campaign_info_try;
        }
        internal int CreateCampaign(DM_campaign_info NewCampaign)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                int newRows = 0;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO campaign (CampaignName, Genre, Status, DMID, CampaignDescription) VALUES" +
                    "( @CampaignName, @Genre, 'Ongoing', @DMID, @CampaignDescription)", connect);
                cmd.Parameters.AddWithValue("@CampaignName", NewCampaign.CampaignName);
                cmd.Parameters.AddWithValue("@Genre", NewCampaign.Genre);
                cmd.Parameters.AddWithValue("@DMID", NewCampaign.DMID);
                cmd.Parameters.AddWithValue("@CampaignDescription", NewCampaign.CampaignDescription);
                newRows += cmd.ExecuteNonQuery();
                connect.Close();
                return newRows;
            }
        }
        internal int getCurrentCampaignID()
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand getMaxIdCmd = new MySqlCommand("SELECT COALESCE(MAX(CampaignID), 0) FROM campaign", connect);
                int camid = Convert.ToInt32(getMaxIdCmd.ExecuteScalar());
                connect.Close();
                return camid;
            }
        }
        internal List<CharacterInfo> getAllCharactersInCampaign(int campaignID)
        {
            List<CharacterInfo> character_info_try = new List<CharacterInfo>();
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM characters " +
                    "JOIN cinventory ON cinventory.CID = characters.CharacterID " +
                    "JOIN cgear ON cgear.CID = characters.CharacterID " +
                    "JOIN cattack ON cattack.CID = characters.CharacterID " +
                    "JOIN cspelltalent ON cspelltalent.CID = characters.CharacterID " +
                    "WHERE characters.CampaignID = @CampaignID", connect);
                cmd.Parameters.AddWithValue("@CampaignID", campaignID);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CharacterInfo ret = new CharacterInfo()
                        {
                            CharacterID = reader.GetInt32(0),
                            CampaignID = reader.GetInt32(1),
                            CUID = reader.GetInt32(2),
                            Title = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            CharacterName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                            CharacterClass = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                            Alignment = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                            Background = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                            STR = reader.GetInt32(8),
                            DEX = reader.GetInt32(9),
                            CON = reader.GetInt32(10),
                            INT = reader.GetInt32(11),
                            WIS = reader.GetInt32(12),
                            CHA = reader.GetInt32(13),
                            AC = reader.GetInt32(14),
                            Health = reader.GetInt32(15),
                            Willpower = reader.GetInt32(16),
                            CharacterInventoryID = reader.GetInt32(17),
                            Item1 = reader.IsDBNull(19) ? string.Empty : reader.GetString(19),
                            Item2 = reader.IsDBNull(20) ? string.Empty : reader.GetString(20),
                            Item3 = reader.IsDBNull(21) ? string.Empty : reader.GetString(21),
                            Item4 = reader.IsDBNull(22) ? string.Empty : reader.GetString(22),
                            Item5 = reader.IsDBNull(23) ? string.Empty : reader.GetString(23),
                            CharacterGearID = reader.GetInt32(24),
                            Gear1 = reader.IsDBNull(26) ? string.Empty : reader.GetString(26),
                            Gear2 = reader.IsDBNull(27) ? string.Empty : reader.GetString(27),
                            Gear3 = reader.IsDBNull(28) ? string.Empty : reader.GetString(28),
                            CharacterAttackID = reader.GetInt32(29),
                            Attack1 = reader.IsDBNull(31) ? string.Empty : reader.GetString(31),
                            Attack2 = reader.IsDBNull(32) ? string.Empty : reader.GetString(32),
                            Attack3 = reader.IsDBNull(33) ? string.Empty : reader.GetString(33),
                            CharacterSpellTalentID = reader.GetInt32(34),
                            ST1 = reader.IsDBNull(36) ? string.Empty : reader.GetString(36),
                            ST2 = reader.IsDBNull(37) ? string.Empty : reader.GetString(37),
                            ST3 = reader.IsDBNull(38) ? string.Empty : reader.GetString(38)
                        };
                        character_info_try.Add(ret);
                    }
                }
            }
            return character_info_try;
        }
        internal int updateCampaign(DM_campaign_info currentcampaign)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE campaign SET CampaignName = @CampaignName, " +
                    "Genre = @Genre, " +
                    "Status = @Status, " +
                    "CampaignDescription = @CampaignDescription " +
                    "WHERE CampaignID = @CampaignID", connect);
                cmd.Parameters.AddWithValue("@CampaignID", CampaignSession.CurrentCampaign.CamID);
                cmd.Parameters.AddWithValue("@CampaignName", currentcampaign.CampaignName);
                cmd.Parameters.AddWithValue("@Genre", currentcampaign.Genre);
                cmd.Parameters.AddWithValue("@Status", currentcampaign.Status);
                cmd.Parameters.AddWithValue("@CampaignDescription", currentcampaign.CampaignDescription);
                int newRows = cmd.ExecuteNonQuery();
                return newRows;
            }
        }
        internal List<DM_campaign_info> getOneDMCampaign(string camID)
        {
            List<DM_campaign_info> campaign_info_try = new List<DM_campaign_info>();
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM campaign WHERE CampaignID = @Campaign " +
                    "OR CampaignName LIKE @Campaign " +
                    "OR Genre LIKE @Campaign " +
                    "OR Status LIKE @Campaign " +
                    "OR CampaignDescription LIKE @Campaign", connect);
                if (int.TryParse(camID, out int campaignId))
                {
                    cmd.Parameters.AddWithValue("@Campaign", campaignId);
                }
                else
                {
                    string searchbystring = "%" + camID + "%";
                    cmd.Parameters.AddWithValue("@Campaign", searchbystring);
                }
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DM_campaign_info ret = new DM_campaign_info()
                        {
                            CampaignID = reader.GetInt32(0),
                            CampaignName = reader.GetString(1),
                            Genre = reader.GetString(2),
                            Status = reader.GetString(3),
                            DMID = reader.GetInt32(4),
                            CampaignDescription = reader.GetString(5)
                        };
                        campaign_info_try.Add(ret);
                    }
                }
            }
            return campaign_info_try;
        }
        internal int deleteOneCampaign(int camID)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM campaign WHERE CampaignID = @CampaignID", connect);
                cmd.Parameters.AddWithValue("@CampaignID", camID);
                int deleteRows = cmd.ExecuteNonQuery();
                return deleteRows;
            }
        }
        internal int addCharacter(CharacterInfo characterInfo)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                int newRows = 0;
                MySqlCommand cmdAddChara = new MySqlCommand("INSERT INTO characters (CampaignID, UID, Title, Name, Class, Alignment" +
                    ", Background, STR, DEX, CON, INTELLIGENCE, WIS, CHA, AC) VALUES " +
                    "(@CampaignID, @UID, @Title, @Name, @Class, @Alignment, @Background, @STR" +
                    ", @DEX, @CON, @INTELLIGENCE, @WIS, @CHA, @AC)", connect);
                cmdAddChara.Parameters.AddWithValue("@CampaignID", characterInfo.CampaignID);
                cmdAddChara.Parameters.AddWithValue("@UID", characterInfo.CUID);
                cmdAddChara.Parameters.AddWithValue("@Title", characterInfo.Title);
                cmdAddChara.Parameters.AddWithValue("@Name", characterInfo.CharacterName);
                cmdAddChara.Parameters.AddWithValue("@Class", characterInfo.CharacterClass);
                cmdAddChara.Parameters.AddWithValue("@Alignment", characterInfo.Alignment);
                cmdAddChara.Parameters.AddWithValue("@Background", characterInfo.Background);
                cmdAddChara.Parameters.AddWithValue("@STR", characterInfo.STR);
                cmdAddChara.Parameters.AddWithValue("@DEX", characterInfo.DEX);
                cmdAddChara.Parameters.AddWithValue("@CON", characterInfo.CON);
                cmdAddChara.Parameters.AddWithValue("@INTELLIGENCE", characterInfo.INT);
                cmdAddChara.Parameters.AddWithValue("@WIS", characterInfo.WIS);
                cmdAddChara.Parameters.AddWithValue("@CHA", characterInfo.CHA);
                cmdAddChara.Parameters.AddWithValue("@AC", characterInfo.AC);
                newRows += cmdAddChara.ExecuteNonQuery();

                int lastInsertedID = (int)cmdAddChara.LastInsertedId;
                MySqlCommand cmdAddgear = new MySqlCommand("INSERT INTO cgear (CID, Gear1, Gear2, Gear3) VALUES " +
                    "(@CID, @Gear1, @Gear2, @Gear3)", connect);
                cmdAddgear.Parameters.AddWithValue("@CID", lastInsertedID);
                cmdAddgear.Parameters.AddWithValue("@Gear1", characterInfo.Gear1);
                cmdAddgear.Parameters.AddWithValue("@Gear2", characterInfo.Gear2);
                cmdAddgear.Parameters.AddWithValue("@Gear3", characterInfo.Gear3);
                newRows += cmdAddgear.ExecuteNonQuery();

                MySqlCommand cmdAddinventory = new MySqlCommand("INSERT INTO cinventory (CID) VALUES (@CID)", connect);
                cmdAddinventory.Parameters.AddWithValue("@CID", lastInsertedID);
                newRows += cmdAddinventory.ExecuteNonQuery();

                MySqlCommand cmdAddattack = new MySqlCommand("INSERT INTO cattack (CID, Attack1, Attack2, Attack3) VALUES " +
                    "(@CID, @Attack1, @Attack2, @Attack3)", connect);
                cmdAddattack.Parameters.AddWithValue("@CID", lastInsertedID);
                cmdAddattack.Parameters.AddWithValue("@Attack1", characterInfo.Attack1);
                cmdAddattack.Parameters.AddWithValue("@Attack2", characterInfo.Attack2);
                cmdAddattack.Parameters.AddWithValue("@Attack3", characterInfo.Attack3);
                newRows += cmdAddattack.ExecuteNonQuery();

                MySqlCommand cmdAddST = new MySqlCommand("INSERT INTO cspelltalent (CID, ST1, ST2, ST3) VALUES " +
                    "(@CID, @ST1, @ST2, @ST3)", connect);
                cmdAddST.Parameters.AddWithValue("@CID", lastInsertedID);
                cmdAddST.Parameters.AddWithValue("@ST1", characterInfo.ST1);
                cmdAddST.Parameters.AddWithValue("@ST2", characterInfo.ST2);
                cmdAddST.Parameters.AddWithValue("@ST3", characterInfo.ST3);
                newRows += cmdAddST.ExecuteNonQuery();

                return newRows;
            }
        }
        internal int getCurrentCharacterID()
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand getMaxIdCmd = new MySqlCommand("SELECT COALESCE(MAX(CampaignID), 0) FROM characters", connect);
                int cid = Convert.ToInt32(getMaxIdCmd.ExecuteScalar());
                connect.Close();
                return cid;
            }
        }
        internal List<CharacterInfo> searchCharacter(string CharaName)
        {
            List<CharacterInfo> chara_info_try = new List<CharacterInfo>();
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM characters " +
                    "JOIN cinventory ON cinventory.CID = characters.CharacterID " +
                    "JOIN cgear ON cgear.CID = characters.CharacterID " +
                    "JOIN cattack ON cattack.CID = characters.CharacterID " +
                    "JOIN cspelltalent ON cspelltalent.CID = characters.CharacterID " +
                    "WHERE Name LIKE @Name", connect);
                string searchbystring = "%" + CharaName + "%";
                cmd.Parameters.AddWithValue("@Name", searchbystring);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CharacterInfo ret = new CharacterInfo()
                        {
                            CharacterID = reader.GetInt32(0),
                            CampaignID = reader.GetInt32(1),
                            CUID = reader.GetInt32(2),
                            Title = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            CharacterName = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                            CharacterClass = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                            Alignment = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                            Background = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                            STR = reader.GetInt32(8),
                            DEX = reader.GetInt32(9),
                            CON = reader.GetInt32(10),
                            INT = reader.GetInt32(11),
                            WIS = reader.GetInt32(12),
                            CHA = reader.GetInt32(13),
                            AC = reader.GetInt32(14),
                            Health = reader.GetInt32(15),
                            Willpower = reader.GetInt32(16),
                            CharacterInventoryID = reader.GetInt32(17),
                            Item1 = reader.IsDBNull(19) ? string.Empty : reader.GetString(19),
                            Item2 = reader.IsDBNull(20) ? string.Empty : reader.GetString(20),
                            Item3 = reader.IsDBNull(21) ? string.Empty : reader.GetString(21),
                            Item4 = reader.IsDBNull(22) ? string.Empty : reader.GetString(22),
                            Item5 = reader.IsDBNull(23) ? string.Empty : reader.GetString(23),
                            CharacterGearID = reader.GetInt32(24),
                            Gear1 = reader.IsDBNull(26) ? string.Empty : reader.GetString(26),
                            Gear2 = reader.IsDBNull(27) ? string.Empty : reader.GetString(27),
                            Gear3 = reader.IsDBNull(28) ? string.Empty : reader.GetString(28),
                            CharacterAttackID = reader.GetInt32(29),
                            Attack1 = reader.IsDBNull(31) ? string.Empty : reader.GetString(31),
                            Attack2 = reader.IsDBNull(32) ? string.Empty : reader.GetString(32),
                            Attack3 = reader.IsDBNull(33) ? string.Empty : reader.GetString(33),
                            CharacterSpellTalentID = reader.GetInt32(34),
                            ST1 = reader.IsDBNull(36) ? string.Empty : reader.GetString(36),
                            ST2 = reader.IsDBNull(37) ? string.Empty : reader.GetString(37),
                            ST3 = reader.IsDBNull(38) ? string.Empty : reader.GetString(38)
                        };
                        chara_info_try.Add(ret);
                    }
                }
            }
            return chara_info_try;
        }
        internal int updateChara(CharacterInfo characterInfo)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                int newRows = 0;
                MySqlCommand cmdUpdateCharacters = new MySqlCommand("UPDATE characters SET Title = @Title, " +
                    "Name = @Name, " +
                    "Class = @Class, " +
                    "Alignment = @Alignment, " +
                    "Background = @Background, " +
                    "STR = @STR, " +
                    "DEX = @DEX, " +
                    "CON = @CON, " +
                    "INTELLIGENCE = @INT," +
                    "WIS = @WIS, " +
                    "CHA = @CHA, " +
                    "AC = @AC, " +
                    "Health = @HP, " +
                    "Willpower = @WILL " +
                    "WHERE CampaignID = @CampaignID AND CharacterID = @CharacterID", connect);
                cmdUpdateCharacters.Parameters.AddWithValue("@CharacterID", characterInfo.CharacterID);
                cmdUpdateCharacters.Parameters.AddWithValue("@CampaignID", characterInfo.CampaignID);
                cmdUpdateCharacters.Parameters.AddWithValue("@Title", characterInfo.Title);
                cmdUpdateCharacters.Parameters.AddWithValue("@Name", characterInfo.CharacterName);
                cmdUpdateCharacters.Parameters.AddWithValue("@Class", characterInfo.CharacterClass);
                cmdUpdateCharacters.Parameters.AddWithValue("@Alignment", characterInfo.Alignment);
                cmdUpdateCharacters.Parameters.AddWithValue("@Background", characterInfo.Background);
                cmdUpdateCharacters.Parameters.AddWithValue("@STR", characterInfo.STR);
                cmdUpdateCharacters.Parameters.AddWithValue("@DEX", characterInfo.DEX);
                cmdUpdateCharacters.Parameters.AddWithValue("@CON", characterInfo.CON);
                cmdUpdateCharacters.Parameters.AddWithValue("@INT", characterInfo.INT);
                cmdUpdateCharacters.Parameters.AddWithValue("@WIS", characterInfo.WIS);
                cmdUpdateCharacters.Parameters.AddWithValue("@CHA", characterInfo.CHA);
                cmdUpdateCharacters.Parameters.AddWithValue("@AC", characterInfo.AC);
                cmdUpdateCharacters.Parameters.AddWithValue("@HP", characterInfo.Health);
                cmdUpdateCharacters.Parameters.AddWithValue("@WILL", characterInfo.Willpower);
                newRows += cmdUpdateCharacters.ExecuteNonQuery();

                MySqlCommand cmdUpdategear = new MySqlCommand("UPDATE cgear SET " +
                    "Gear1 = @g1, " +
                    "Gear2 = @g2, " +
                    "Gear3 = @g3 " +
                    "WHERE CID = @CID", connect);
                cmdUpdategear.Parameters.AddWithValue("@CID", characterInfo.CharacterID);
                cmdUpdategear.Parameters.AddWithValue("@g1", characterInfo.Gear1);
                cmdUpdategear.Parameters.AddWithValue("@g2", characterInfo.Gear2);
                cmdUpdategear.Parameters.AddWithValue("@g3", characterInfo.Gear3);
                newRows += cmdUpdategear.ExecuteNonQuery();

                MySqlCommand cmdUpdateattack = new MySqlCommand("UPDATE cattack SET " +
                    "Attack1 = @atk1, " +
                    "Attack2 = @atk2, " +
                    "Attack3 = @atk3 " +
                    "WHERE CID = @CID", connect);
                cmdUpdateattack.Parameters.AddWithValue("@CID", characterInfo.CharacterID);
                cmdUpdateattack.Parameters.AddWithValue("@atk1", characterInfo.Attack1);
                cmdUpdateattack.Parameters.AddWithValue("@atk2", characterInfo.Attack2);
                cmdUpdateattack.Parameters.AddWithValue("@atk3", characterInfo.Attack3);
                newRows += cmdUpdateattack.ExecuteNonQuery();

                MySqlCommand cmdUpdatest = new MySqlCommand("UPDATE cspelltalent SET " +
                    "ST1 = @st1, " +
                    "ST2 = @st2, " +
                    "ST3 = @st3 " +
                    "WHERE CID = @CID", connect);
                cmdUpdatest.Parameters.AddWithValue("@CID", characterInfo.CharacterID);
                cmdUpdatest.Parameters.AddWithValue("@st1", characterInfo.ST1);
                cmdUpdatest.Parameters.AddWithValue("@st2", characterInfo.ST2);
                cmdUpdatest.Parameters.AddWithValue("@st3", characterInfo.ST3);
                newRows += cmdUpdatest.ExecuteNonQuery();

                return newRows;
            }
        }
        internal int deleteOneChara(int charaID)
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM characters WHERE CharacterID = @CharacterID", connect);
                cmd.Parameters.AddWithValue("@CharacterID", charaID);
                int deleteRows = cmd.ExecuteNonQuery();
                return deleteRows;
            }
        }
        internal List<DM_campaign_info> getAllCampaign()
        {
            List<DM_campaign_info> campaign_info_try = new List<DM_campaign_info>();
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM campaign", connect);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DM_campaign_info ret = new DM_campaign_info()
                        {
                            CampaignID = reader.GetInt32(0),
                            CampaignName = reader.GetString(1),
                            Genre = reader.GetString(2),
                            Status = reader.GetString(3),
                            DMID = reader.GetInt32(4),
                            CampaignDescription = reader.GetString(5)
                        };
                        campaign_info_try.Add(ret);
                    }
                }
            }
            return campaign_info_try;
        }
    }
}