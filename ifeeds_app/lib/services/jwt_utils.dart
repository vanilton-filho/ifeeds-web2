import 'package:get_storage/get_storage.dart';
import 'package:jwt_decoder/jwt_decoder.dart';

class JwtUtils {

  static bool isExpired(GetStorage storage){
    var jwt = storage.read("jwt");
    var isExpired = JwtDecoder.isExpired(jwt);
    
    if(isExpired){
        return true;
    }

    return false;
  }
      
      
}