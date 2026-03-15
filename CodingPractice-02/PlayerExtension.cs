using System;

static class PlayerExtension {
    public static string GetInfo(this Player player) {
        return $"[{player.Name}] 레벨 : {player.Level}, 경험치 : {player.Experience}";
    }

    public static string CanLevelUp(this Player player) {
        return $"레벨업 가능? : {player.Experience >= 100}";
    }

    public static string LevelUp(this Player player) {
        player.Experience -= 100;
        player.Level += 1;
        return $"{player.Name}이(가) 레벨업!  현재 레벨 : {player.Level}";
    }
}