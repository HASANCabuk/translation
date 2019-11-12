﻿using NUnit.Framework;
using Shouldly;
using StandardRepository.Models.Entities;
using StandardRepository.Models.Entities.Schemas;

using Translation.Data.Entities.Domain;
using static Translation.Common.Tests.TestHelpers.AssertPropertyTestHelper;

namespace Translation.Server.Unit.Tests.Data.Entities
{
    [TestFixture]
    public class LabelTranslationEntityTests
    {
        [Test]
        public void LabelTranslation()
        {
            var entity = new LabelTranslation();

            var entityType = entity.GetType();
            var properties = entityType.GetProperties();

            entityType.BaseType.Name.ShouldBe(nameof(BaseEntity));
            entityType.GetInterface(nameof(ISchemaDomain)).ShouldNotBeNull();

            AssertLongProperty(properties, "OrganizationId", entity.OrganizationId);
            AssertGuidProperty(properties, "OrganizationUid", entity.OrganizationUid);
            AssertStringProperty(properties, "OrganizationName", entity.OrganizationName);

            AssertLongProperty(properties, "ProjectId", entity.ProjectId);
            AssertGuidProperty(properties, "ProjectUid", entity.ProjectUid);
            AssertStringProperty(properties, "ProjectName", entity.ProjectName);

            AssertLongProperty(properties, "LabelId", entity.LabelId);
            AssertGuidProperty(properties, "LabelUid", entity.LabelUid);
            AssertStringProperty(properties, "LabelName", entity.LabelName);

            AssertLongProperty(properties, "LanguageId", entity.LanguageId);
            AssertGuidProperty(properties, "LanguageUid", entity.LanguageUid);
            AssertStringProperty(properties, "LanguageName", entity.LanguageName);

            AssertStringProperty(properties,"TranslationText",entity.TranslationText);
            AssertStringProperty(properties,"Description",entity.Description);
            AssertBooleanProperty(properties,"IsActive",entity.IsActive);
        }

    }
}