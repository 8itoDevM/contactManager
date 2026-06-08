using System;

public static class ContactMapper {
    public static ContactDto ToDto(this Contact contact) {
        return new ContactDto {
            Id = contact.Id,
            Name = contact.Name,
            Email = contact.Email,
            Phone = contact.Phone
        };
    }

    public static Contact ToEntity(this CreateContactDto dto) {
        return new Contact {
            Name = dto.Name,
            Email = dto.Email,
            Phone = dto.Phone
        };
    }
}