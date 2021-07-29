import 'package:shared_preferences/shared_preferences.dart';

class StorageUtil {
  static StorageUtil? storageUtil;
  static SharedPreferences? preferences;

  static Future<void> getInstance() async {
    if (storageUtil == null) {
      // keep local instance till it is fully initialized.
      var secureStorage = StorageUtil._();
      await secureStorage._init();
      storageUtil = secureStorage;
    }
  }

  StorageUtil._();

  Future _init() async {
    preferences = await SharedPreferences.getInstance();
  }

  // get string
  static String getString(String key, {String defValue = ''}) {
    if (preferences == null) return defValue;
    return preferences!.getString(key) ?? defValue;
  }

  // put string
  static Future<bool> putString(String key, String value) {
    if (preferences == null) return Future.value(false);
    return preferences!.setString(key, value);
  }
}
