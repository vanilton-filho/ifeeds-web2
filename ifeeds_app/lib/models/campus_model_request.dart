import 'dart:convert';

class CampusModelRequest {
  
  String? nome;
 
 
  CampusModelRequest({
    this.nome,
  });

  Map<String, dynamic> toMap() {
    return {
      'nome': nome,
    };
  }

  factory CampusModelRequest.fromMap(Map<String, dynamic> map) {
    return CampusModelRequest(
      nome: map['nome'],
    );
  }

  String toJson() => json.encode(toMap());

  factory CampusModelRequest.fromJson(String source) => CampusModelRequest.fromMap(json.decode(source));
}
