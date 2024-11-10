﻿using ClassesOrganizationSistem.Domain.Entities.UserEntites;

namespace ClassesOrganizationSistem.Application.Models.UserDtos
{
    public class CreateAddRoleRequestDto
    {
        public int UserId { get; set; }

        public int SchoolId { get; set; }

        public int RoleId { get; set; }

        public AddRoleRequest MapToAddRoleRequest()
        {
            return new AddRoleRequest()
            {
                UserId = UserId,
                SchoolId = SchoolId,
                RoleId = RoleId
            };
        }
    }
}
